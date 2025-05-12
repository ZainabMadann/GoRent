using ClassLibrary.Model;
using Microsoft.AspNetCore.Mvc;

public class CategoryController : Controller
{
    private readonly CourseDBContext _context;

    public CategoryController(CourseDBContext context)
    {
        _context = context;
    }

    // POST: Category/Add
    [HttpPost]
    public IActionResult Add([FromForm] string categoryName, [FromForm] string categoryDescription)
    {
        if (string.IsNullOrWhiteSpace(categoryName) || string.IsNullOrWhiteSpace(categoryDescription))
        {
            return BadRequest("Category name and description are required.");
        }

        var newCategory = new ClassLibrary.Model.Category
        {
            Name = categoryName,
            Description = categoryDescription
        };


        _context.Categories.Add(newCategory);
        _context.SaveChanges();

        return RedirectToAction("ManageCategories"); // or wherever your list view is
    }

    public IActionResult ManageCat()
    {
        return View();
    }

}
