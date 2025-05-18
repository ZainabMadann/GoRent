using ClassLibrary.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class EquipmentController : Controller
    {
        private readonly CourseDBContext _context;
        private readonly IWebHostEnvironment _env;

        public EquipmentController(CourseDBContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        [HttpGet]
        public IActionResult Manage()
        {
            var viewModel = new ManageEquipmentViewModel
            {
                EquipmentList = _context.Equipment
                    .Include(e => e.Category)
                    .Include(e => e.EquipmentStatus)
                    .ToList(),
                CreateEquipment = new CreateEquipmentViewModel(),
                Categories = _context.Categories.ToList(),
                Statuses = _context.EquipmentStatuses.ToList()
            };

            return View("ManageEq", viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ManageEquipmentViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.EquipmentList = _context.Equipment
                    .Include(e => e.Category)
                    .Include(e => e.EquipmentStatus)
                    .ToList();
                model.Categories = _context.Categories.ToList();

                return View("ManageEq", model);
            }

            var create = model.CreateEquipment;
            string? imagePath = null;

            if (create.EquipmentImage != null)
            {
                var uploads = Path.Combine(_env.WebRootPath, "images");
                Directory.CreateDirectory(uploads);

                var fileName = Guid.NewGuid() + Path.GetExtension(create.EquipmentImage.FileName);
                var filePath = Path.Combine(uploads, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await create.EquipmentImage.CopyToAsync(stream);
                }

                imagePath = "/images/" + fileName;
            }

            var equipment = new Equipment
            {
                Name = create.Name,
                Description = create.Description,
                RentalRate = create.RentalRate,
                CategoryId = create.Category_ID,
                EquipmentStatusId = create.Equipment_Status_ID,
                EquipmentConditionId = 1,
                ImagePath = imagePath
            };

            _context.Equipment.Add(equipment);
            await _context.SaveChangesAsync();

            return RedirectToAction("Manage");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var equipment = _context.Equipment
                .Include(e => e.Category)
                .Include(e => e.EquipmentStatus)
                .FirstOrDefault(e => e.EquipmentId == id);

            if (equipment == null)
                return NotFound();

            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.Statuses = _context.EquipmentStatuses.ToList();

            return View("EqDetails", equipment);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(IFormFile? EquipmentImage, int EquipmentId, string Name, string Description,
    decimal RentalRate, int CategoryId, int EquipmentStatusId)
        {
            var equipment = await _context.Equipment.FindAsync(EquipmentId);
            if (equipment == null) return NotFound();

            equipment.Name = Name;
            equipment.Description = Description;
            equipment.RentalRate = RentalRate;
            equipment.CategoryId = CategoryId;
            equipment.EquipmentStatusId = EquipmentStatusId;

            // Image upload handling
            if (EquipmentImage != null)
            {
                var uploads = Path.Combine(_env.WebRootPath, "images");
                Directory.CreateDirectory(uploads);
                var fileName = Guid.NewGuid() + Path.GetExtension(EquipmentImage.FileName);
                var filePath = Path.Combine(uploads, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await EquipmentImage.CopyToAsync(stream);
                }

                equipment.ImagePath = "/images/" + fileName;
            }

            await _context.SaveChangesAsync();

            return RedirectToAction("Details", new { id = equipment.EquipmentId });
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var equipment = await _context.Equipment.FindAsync(id);
            if (equipment == null)
                return NotFound();

            if (!string.IsNullOrEmpty(equipment.ImagePath))
            {
                var imagePath = Path.Combine(_env.WebRootPath, equipment.ImagePath.TrimStart('/'));
                if (System.IO.File.Exists(imagePath))
                {
                    System.IO.File.Delete(imagePath);
                }
            }

            _context.Equipment.Remove(equipment);
            await _context.SaveChangesAsync();

            return RedirectToAction("Manage");
        }
        [HttpGet]
        public IActionResult FilterManage(string searchTerm, int? filterCategory)
        {
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

            var equipmentList = equipmentQuery.ToList();

            return PartialView("_FilteredEquipmentManagePartial", equipmentList);
        }




    }
}
