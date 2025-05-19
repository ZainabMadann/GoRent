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

        // Redirect to payment or confirmation page
        return RedirectToAction("Payment", "RentalTransaction", new { rentalRequestId = rentalRequest.RentalRequestId });
    }
    public IActionResult MyRequests(string? search, string? filter)
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
            query = _context.RentalRequests;
        }
        else
        {
            int userId = int.Parse(userIdStr);
            query = _context.RentalRequests.Where(r => r.UserId == userId);
        }

        if (!string.IsNullOrEmpty(filter) && filter != "all")
        {
            query = filter switch
            {
                "pending" => query.Where(r => r.RequestStatusId == 1),
                "approved" => query.Where(r => r.RequestStatusId == 2),
                "rejected" => query.Where(r => r.RequestStatusId == 3),
                _ => query
            };
        }

        if (!string.IsNullOrEmpty(search))
        {
            query = query.Where(r =>
                r.Description.Contains(search) ||
                r.Equipment.Name.Contains(search));
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
