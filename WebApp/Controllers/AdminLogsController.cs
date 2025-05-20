using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClassLibrary.Model;

public class AdminLogsController : Controller
{
    private readonly CourseDBContext _context;

    public AdminLogsController(CourseDBContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var role = HttpContext.Session.GetString("Role");
        if (role != "Admin")
            return RedirectToAction("Login", "Auth");

        var logs = _context.Logs
            .Include(l => l.User)
            .OrderByDescending(l => l.TimeStamp)
            .ToList();

        return View("ManageLogs", logs);
    }


    // Add logs manually in other controllers like this:
    public void LogAction(string action, int userId, string entity, string from, string to)
    {
        var log = new Log
        {
            Action = action,
            UserId = userId,
            EntityChanged = entity,
            OriginalValue = from,
            CurrentValue = to,
            TimeStamp = DateTime.Now
        };

        _context.Logs.Add(log);
        _context.SaveChanges();
    }
}
