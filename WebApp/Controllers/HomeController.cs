using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    //public IActionResult Register()
    //{
    //    return View();
    //}

    //public IActionResult Login()
    //{
    //    return View();
    //}

    //public IActionResult Profile()
    //{
    //    return View();
    //}

    public IActionResult Feedback()
    {
        return View();
    }

    public IActionResult Categories()
    {
        return View();
    }

    public IActionResult EqDetails()
    {
        return View();
    }

    public IActionResult Notifications()
    {
        return View();
    }
    public IActionResult RequestDetails()
    {
        return View();
    }

    public IActionResult TransactionDetails()
    {
        return View();
    }

    public IActionResult Payment()
    {
        return View();
    }

    public IActionResult MangeComments()
    {
        return View();
    }

    public IActionResult ManageCat()
    {
        return View();
    }

    //public IActionResult ManageEq()
    //{
    //    return View();
    //}

    public IActionResult ManageRentalRequests()
    {
        return View();
    }
    public IActionResult ManageTransactions()
    {
        return View();
    }

    public IActionResult CommentDetails()
    {
        return View();
    }

    public IActionResult CategotyEquioments()
    {
        return View();
    }

    public IActionResult ManageLogs()
    {
        return View();
    }

    public IActionResult ManageStatus()
    {
        return View();
    }

    public IActionResult ContactUs()
    {
        return View();
    }

    public IActionResult Dashboard()
    {
        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
