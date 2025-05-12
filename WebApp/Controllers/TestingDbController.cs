
using Microsoft.AspNetCore.Mvc;
using ClassLibrary.Model;
using Microsoft.EntityFrameworkCore;
namespace WebApp.Controllers
{
    public class TestingDbController : Controller
    {
        private readonly CourseDBContext _context;
        public TestingDbController(CourseDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            try
            {
                if (_context.Database.CanConnect())
                {
                    ViewBag.Message = "Success! Database connection works.";
                    ViewBag.Success = true;
                }
                else
                {
                    ViewBag.Message = "Error: Cannot connect to the database.";
                    ViewBag.Success = false;
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = $"Exception occurred: {ex.Message}";
                ViewBag.Success = false;
            }

            return View();
        }

    }
}