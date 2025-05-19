using ClassLibrary.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class RentalController : Controller
{
    private readonly CourseDBContext _context;

    public RentalController(CourseDBContext context)
    {
        _context = context;
    }

    [HttpPost]
    public IActionResult CreateRentalRequest(DateTime StartDate, DateTime EndDate, int EquipmentId)
    {
        var userIdStr = HttpContext.Session.GetString("UserId");
        if (string.IsNullOrEmpty(userIdStr))
        {
            return RedirectToAction("Login", "Auth");
        }
        int userId = int.Parse(userIdStr);


        var rentalRequest = new RentalRequest
        {
            EquipmentId = EquipmentId,
            StartDate = StartDate,
            EndDate = EndDate,
            RequestDate = DateTime.Today,
            UserId = userId,
            RequestStatusId = 1 // Default status (e.g., 'Pending')
        };

        _context.RentalRequests.Add(rentalRequest);
        _context.SaveChanges();

        // Redirect to payment or confirmation page
        return RedirectToAction("Payment", "RentalTransaction", new { rentalRequestId = rentalRequest.RentalRequestId });
    }
    public IActionResult MyRequests()
    {
        var userIdStr = HttpContext.Session.GetString("UserId");
        if (string.IsNullOrEmpty(userIdStr))
        {
            return RedirectToAction("Login", "Auth");
        }

        int userId = int.Parse(userIdStr);
        var requests = _context.RentalRequests
            .Where(r => r.UserId == userId)
            .Include(r => r.Equipment)         // optional: include related Equipment info
            .Include(r => r.RequestStatus)     // optional: include status info
            .OrderByDescending(r => r.RequestDate)
            .ToList();

        return PartialView("_RentalRequestsPartial", requests);
    }

}
