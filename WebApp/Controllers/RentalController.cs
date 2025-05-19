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
    public IActionResult CreateRentalRequest(DateTime StartDate, DateTime EndDate, int EquipmentId, string? Description)
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
            RequestStatusId = 1, // Default: Pending
            Description = Description
        };

        _context.RentalRequests.Add(rentalRequest);
        _context.SaveChanges();

        return RedirectToAction("Payment", "Home");
    }

    //public IActionResult MyRequests()
    //{
    //    var userIdStr = HttpContext.Session.GetString("UserId");
    //    if (string.IsNullOrEmpty(userIdStr))
    //    {
    //        return RedirectToAction("Login", "Auth");
    //    }

    //    int userId = int.Parse(userIdStr);
    //    var requests = _context.RentalRequests
    //        .Where(r => r.UserId == userId)
    //        .Include(r => r.Equipment)         // optional: include related Equipment info
    //        .Include(r => r.RequestStatus)     // optional: include status info
    //        .OrderByDescending(r => r.RequestDate)
    //        .ToList();

    //    return PartialView("_RentalRequestsPartial", requests);
    //}
    public IActionResult MyRequests()
    {
        var userIdStr = HttpContext.Session.GetString("UserId");
        var userRole = HttpContext.Session.GetString("Role");

        if (string.IsNullOrEmpty(userIdStr) || string.IsNullOrEmpty(userRole))
        {
            return RedirectToAction("Login", "Auth");
        }

        IQueryable<RentalRequest> query;

        if (userRole == "Admin" || userRole == "Manager")
        {
            // Admin/Manager: show all requests
            query = _context.RentalRequests;
        }
        else
        {
            // Customer: show only their own requests
            int userId = int.Parse(userIdStr);
            query = _context.RentalRequests.Where(r => r.UserId == userId);
        }

        var requests = query
            .Include(r => r.Equipment)
            .Include(r => r.RequestStatus)
            .OrderByDescending(r => r.RequestDate)
            .ToList();

        return PartialView("_RentalRequestsPartial", requests);
    }

    public IActionResult RequestDetails(int id)
    {
        var request = _context.RentalRequests
            .Include(r => r.Equipment)
            .Include(r => r.RequestStatus)
            .FirstOrDefault(r => r.RentalRequestId == id);

        if (request == null)
        {
            return Content("Rental request not found for ID: " + id);
        }

        ViewBag.UserRole = HttpContext.Session.GetString("UserRole");
        return View(request);
    }

    [HttpPost]
    public IActionResult UpdateDescription(int RentalRequestId, string Description)
    {
        var request = _context.RentalRequests.FirstOrDefault(r => r.RentalRequestId == RentalRequestId);
        if (request == null)
        {
            return NotFound("Rental request not found.");
        }

        request.Description = Description;
        _context.SaveChanges();

        return RedirectToAction("RequestDetails", new { id = RentalRequestId });
    }
    [HttpPost]
    public IActionResult ApproveRequest(int RentalRequestId)
    {
        var request = _context.RentalRequests.FirstOrDefault(r => r.RentalRequestId == RentalRequestId);
        if (request == null)
        {
            return NotFound("Rental request not found.");
        }

        request.RequestStatusId = 2;
        _context.SaveChanges();

        return RedirectToAction("RequestDetails", new { id = RentalRequestId });
    }

    [HttpPost]
    public IActionResult RejectRequest(int RentalRequestId)
    {
        var request = _context.RentalRequests.FirstOrDefault(r => r.RentalRequestId == RentalRequestId);
        if (request == null)
        {
            return NotFound("Rental request not found.");
        }

        request.RequestStatusId = 3;
        _context.SaveChanges();

        return RedirectToAction("RequestDetails", new { id = RentalRequestId });
    }


}
