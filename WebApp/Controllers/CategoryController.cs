using ClassLibrary.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

public class CategoryController : Controller
{
    private readonly CourseDBContext _context;

    public CategoryController(CourseDBContext context)
    {
        _context = context;
    }

    public IActionResult ManageCat()
    {
        var categories = _context.Categories.ToList();
        return View(categories);
    }

    [HttpPost]
    public IActionResult Add([FromForm] string categoryName, [FromForm] string categoryDescription)
    {
        if (string.IsNullOrWhiteSpace(categoryName) || string.IsNullOrWhiteSpace(categoryDescription))
            return BadRequest("Category name and description are required.");

        var newCategory = new ClassLibrary.Model.Category

        {
            Name = categoryName,
            Description = categoryDescription
        };

        _context.Categories.Add(newCategory);
        _context.SaveChanges();

        return RedirectToAction("ManageCat");
    }

    public IActionResult CategoryDetails(int categoryId)
    {
        var category = _context.Categories.FirstOrDefault(c => c.CategoryId == categoryId);
        if (category == null) return NotFound();

        var equipment = _context.Equipment
            .Where(e => e.CategoryId == categoryId)
            .ToList();

        ViewBag.EquipmentList = equipment;
        return View("CategoryDetails", category);
    }

    [HttpPost]
    public IActionResult Edit(int CategoryId, string Name, string Description)
    {
        var category = _context.Categories.Find(CategoryId);
        if (category == null) return NotFound();

        category.Name = Name;
        category.Description = Description;
        _context.SaveChanges();

        return RedirectToAction("CategoryDetails", new { categoryId = CategoryId });
    }

    [HttpPost]
    [HttpPost]
    [HttpPost]
    public IActionResult Delete(int id)
    {
        var category = _context.Categories.FirstOrDefault(c => c.CategoryId == id);
        if (category == null) return NotFound();

        bool isUsed = _context.Equipment.Any(e => e.CategoryId == id);
        if (isUsed)
        {
            TempData["DeleteError"] = "❌ Cannot delete this category. Please delete its associated equipments first.";

            var equipment = _context.Equipment.Where(e => e.CategoryId == id).ToList();
            ViewBag.EquipmentList = equipment;

            return View("CategoryDetails", category);
        }

        _context.Categories.Remove(category);
        _context.SaveChanges();

        return RedirectToAction("ManageCat");
    }
    public IActionResult AllCategoriesAndEquipments(string searchTerm, int? filterCategory)
    {
        // Start with full category list (for dropdown)
        var allCategories = _context.Categories.ToList();

        // Filter categories based on searchTerm
        var filteredCategories = _context.Categories.AsQueryable();

        if (!string.IsNullOrWhiteSpace(searchTerm))
        {
            filteredCategories = filteredCategories.Where(c =>
                c.Name.Contains(searchTerm) || c.Description.Contains(searchTerm));
        }

        var categories = filteredCategories.ToList();

        // Prepare dropdown with full unfiltered list
        ViewBag.CategorySelectList = new SelectList(allCategories, "CategoryId", "Name", filterCategory);

        // Filter equipment as before
        var equipmentQuery = _context.Equipment
            .Include(e => e.Category)
            .Include(e => e.EquipmentStatus)
            .AsQueryable();

        if (!string.IsNullOrWhiteSpace(searchTerm))
        {
            equipmentQuery = equipmentQuery.Where(e =>
                e.Name.Contains(searchTerm) || e.Description.Contains(searchTerm));
        }

        if (filterCategory.HasValue && filterCategory.Value > 0)
        {
            equipmentQuery = equipmentQuery.Where(e => e.CategoryId == filterCategory.Value);
        }

        var equipment = equipmentQuery.ToList();

        var model = new Tuple<List<ClassLibrary.Model.Category>, List<ClassLibrary.Model.Equipment>>(
            categories,
            equipment
        );

        return View("Categories", model);
    }

    public IActionResult FilterAll(string searchTerm, int? filterCategory)
    {
        var categories = _context.Categories.AsQueryable();

        if (!string.IsNullOrWhiteSpace(searchTerm))
            categories = categories.Where(c => c.Name.Contains(searchTerm) || c.Description.Contains(searchTerm));

        if (filterCategory.HasValue && filterCategory.Value > 0)
            categories = categories.Where(c => c.CategoryId == filterCategory.Value);

        var filteredCategories = categories.ToList();

        var equipmentQuery = _context.Equipment
            .Include(e => e.Category)
            .Include(e => e.EquipmentStatus)
            .AsQueryable();

        if (!string.IsNullOrWhiteSpace(searchTerm))
            equipmentQuery = equipmentQuery.Where(e => e.Name.Contains(searchTerm) || e.Description.Contains(searchTerm));

        if (filterCategory.HasValue && filterCategory.Value > 0)
            equipmentQuery = equipmentQuery.Where(e => e.CategoryId == filterCategory.Value);

        var filteredEquipment = equipmentQuery.ToList();

        var model = new Tuple<List<ClassLibrary.Model.Category>, List<ClassLibrary.Model.Equipment>>(
            filteredCategories,
            filteredEquipment
        );

        ViewBag.CategorySelectList = new SelectList(_context.Categories.ToList(), "CategoryId", "Name", filterCategory);

        // Detect AJAX
        if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
        {
            return PartialView("_FilteredCardsOnly", model); // light partial
        }

        return View("Categories", model); // Normal full-page render
    }



}
