using ClassLibrary.Model;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

public class AdminController : Controller
{
    private readonly CourseDBContext _context;

    public AdminController(CourseDBContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> AddCategory(CategoryViewModel model)
    {
        if (ModelState.IsValid)
        {
            var category = new Category
            {
                Name = model.Name,
                Description = model.Description
            };

            _context.Categories.Add(category);
            await _context.SaveChangesAsync();
            TempData["SuccessMessage"] = "Category added successfully.";
            return RedirectToAction("ManageCategories");
        }

        TempData["ErrorMessage"] = "Failed to add category.";
        return RedirectToAction("ManageCategories");
    }

    public IActionResult ManageCategories()
    {
        var categories = _context.Categories.ToList();
        return View(categories);
    }
}
