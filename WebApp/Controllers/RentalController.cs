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
            RequestStatusId = 1,
            Description = Description
        };

        _context.RentalRequests.Add(rentalRequest);
        _context.SaveChanges(); // ⬅️ Save to ensure RentalRequestId is generated

        // ⬅️ Now log with valid RentalRequestId
        _context.Logs.Add(new Log
        {
            Action = "CREATE_REQUEST",
            UserId = userId,
            EntityChanged = "RentalRequest",
            OriginalValue = "-",
            CurrentValue = $"Request created (ID: {rentalRequest.RentalRequestId})",
            TimeStamp = DateTime.Now
        });

        var equipment = _context.Equipment.FirstOrDefault(e => e.EquipmentId == EquipmentId);
        var user = _context.Users.FirstOrDefault(u => u.UserId == userId);

        var managers = _context.Users.Where(u => u.Role == "Manager").ToList();
        foreach (var manager in managers)
        {
            var notification = new Notification
            {
                Massege = $"New rental request for '{equipment?.Name}' was made by {user?.Name ?? user?.Email}.",
                Date = DateTime.Today,
                UserId = manager.UserId,
                IsRead = false
            };
            _context.Notifications.Add(notification);
        }

        _context.SaveChanges(); // ⬅️ Save everything (log + notifications)

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

        _context.Logs.Add(new Log
        {
            Action = "UPDATE_REQUEST",
            UserId = request.UserId,
            EntityChanged = "RentalRequest",
            OriginalValue = "-",
            CurrentValue = $"Description updated (ID: {request.RentalRequestId})",
            TimeStamp = DateTime.Now
        });
        _context.SaveChanges();

        return RedirectToAction("RequestDetails", new { id = RentalRequestId });
    }
    [HttpPost]
    public IActionResult ApproveRequest(int RentalRequestId)
    {
        var request = _context.RentalRequests
            .Include(r => r.Equipment)
            .FirstOrDefault(r => r.RentalRequestId == RentalRequestId);

        if (request == null)
        {
            return NotFound("Rental request not found.");
        }

        request.RequestStatusId = 2;
        _context.SaveChanges();

        _context.Logs.Add(new Log
        {
            Action = "APPROVE_REQUEST",
            UserId = request.UserId,
            EntityChanged = "RentalRequest",
            OriginalValue = "Pending",
            CurrentValue = "Approved",
            TimeStamp = DateTime.Now
        });


        var notification = new Notification
        {
            Massege = $"Your rental request for '{request.Equipment.Name}' was approved.",
            Date = DateTime.Now,
            UserId = request.UserId,
            IsRead = false
        };

        _context.Notifications.Add(notification);
        _context.SaveChanges();

        return RedirectToAction("RequestDetails", new { id = RentalRequestId });
    }


    [HttpPost]
    public IActionResult RejectRequest(int RentalRequestId)
    {
        var request = _context.RentalRequests
    .Include(r => r.Equipment)
    .FirstOrDefault(r => r.RentalRequestId == RentalRequestId);

        if (request == null)
        {
            return NotFound("Rental request not found.");
        }

        request.RequestStatusId = 3;
        _context.SaveChanges();

        _context.Logs.Add(new Log
        {
            Action = "REJECT_REQUEST",
            UserId = request.UserId,
            EntityChanged = "RentalRequest",
            OriginalValue = "Pending",
            CurrentValue = "Rejected",
            TimeStamp = DateTime.Now
        });


        // Create notification
        var notification = new Notification
        {
            Massege = $"Your rental request for '{request.Equipment.Name}' was rejected.",
            Date = DateTime.Now,
            UserId = request.UserId,
            IsRead = false
        };

        _context.Notifications.Add(notification);
        _context.SaveChanges();

        return RedirectToAction("RequestDetails", new { id = RentalRequestId });
    }

    public IActionResult RentedNowPartial(string search, string filter)
    {
        var userIdStr = HttpContext.Session.GetString("UserId");
        var userRole = HttpContext.Session.GetString("Role");

        if (string.IsNullOrEmpty(userIdStr) || string.IsNullOrEmpty(userRole))
        {
            return Content("Please login first");
        }

        int userId = int.Parse(userIdStr);

        IQueryable<RentalRequest> query = _context.RentalRequests
            .Include(r => r.Equipment)
            .Include(r => r.RequestStatus)
            .Include(r => r.RentalTransactions)
            .Where(r => r.RequestStatusId == 2 && // Approved
                        r.RentalTransactions.Any(t => t.PaymentStatus == "Paid")); // Only paid transactions

        if (userRole != "Admin" && userRole != "Manager")
        {
            query = query.Where(r => r.UserId == userId);
        }

        if (!string.IsNullOrEmpty(search))
        {
            query = query.Where(r => r.Equipment.Name.Contains(search));
        }

        if (filter == "active")
        {
            query = query.Where(r => r.EndDate >= DateTime.Today);
        }
        else if (filter == "overdue")
        {
            query = query.Where(r => r.EndDate < DateTime.Today);
        }

        var rentedItems = query.OrderByDescending(r => r.RequestDate).ToList();

        return PartialView("_RentedNowPartial", rentedItems);
    }

    [HttpPost]
    public IActionResult ReturnEquipment(int RentalRequestId, int EquipmentId, int RentalTransactionId, int EquipmentConditionId)
    {
        var userIdStr = HttpContext.Session.GetString("UserId");
        if (string.IsNullOrEmpty(userIdStr))
        {
            return RedirectToAction("Login", "Auth");
        }

        int userId = int.Parse(userIdStr);

        // Check if this equipment has already been returned for this transaction
        if (_context.ReturnRecords.Any(r => r.RentalTransactionId == RentalTransactionId))
        {
            TempData["Error"] = "This equipment has already been returned";
            return RedirectToAction("_RentedNowPartial");
        }

        var returnRecord = new ReturnRecord
        {
            ReturnDate = DateTime.Today,
            RentalTransactionId = RentalTransactionId,
            EquipmentId = EquipmentId,
            UserId = userId,
            EquipmentConditionId = EquipmentConditionId
        };

        _context.ReturnRecords.Add(returnRecord);

        // Update rental request status to returned
        var rentalRequest = _context.RentalRequests.FirstOrDefault(r => r.RentalRequestId == RentalRequestId);
        if (rentalRequest != null)
        {
            rentalRequest.RequestStatusId = 4; // 4 = Returned
        }

        try
        {
            _context.SaveChanges();
            TempData["Message"] = "Equipment successfully returned";
            //throw new Exception();
        }
        catch (DbUpdateException ex)
        {
            TempData["Error"] = "Error returning equipment: " + ex.Message;

            throw new Exception();
        }

        _context.Logs.Add(new Log
        {
            Action = "RETURN_EQUIPMENT",
            UserId = userId,
            EntityChanged = "ReturnRecord",
            OriginalValue = "-",
            CurrentValue = $"Returned equipment (Transaction ID: {RentalTransactionId})",
            TimeStamp = DateTime.Now
        });
        _context.SaveChanges();

        _context.Logs.Add(new Log
        {
            Action = "RETURN_EQUIPMENT",
            UserId = userId,
            EntityChanged = "ReturnRecord",
            OriginalValue = "-",
            CurrentValue = $"Returned equipment (Transaction ID: {RentalTransactionId})",
            TimeStamp = DateTime.Now
        });
        _context.SaveChanges();


        return RedirectToAction("Profile", "Auth");

    }
    [HttpGet]
    public async Task<IActionResult> GetReturnHistory()
    {
        // Check if user is authenticated
        var userIdStr = HttpContext.Session.GetString("UserId");
        var userRole = HttpContext.Session.GetString("Role");

        if (string.IsNullOrEmpty(userIdStr) || string.IsNullOrEmpty(userRole))
        {
            return Unauthorized("Please login to view return history");
        }

        int userId = int.Parse(userIdStr);
        IQueryable<ReturnRecord> query = _context.ReturnRecords
            .Include(r => r.Equipment)
            .Include(r => r.EquipmentCondition)
            .Include(r => r.User);

        // If user is not admin/manager, filter by their own records
        if (userRole != "Admin" && userRole != "Manager")
        {
            query = query.Where(r => r.UserId == userId);
        }

        var returnHistory = await query
            .OrderByDescending(r => r.ReturnDate)
            .ToListAsync();

        return PartialView("_ReturnHistoryPartial", returnHistory);
    }
}
