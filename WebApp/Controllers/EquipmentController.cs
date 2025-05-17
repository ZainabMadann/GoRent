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
                CreateEquipment = new CreateEquipmentViewModel()
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
                EquipmentConditionId = 1, // default
                ImagePath = imagePath
            };

            _context.Equipment.Add(equipment);
            await _context.SaveChangesAsync();

            return RedirectToAction("Manage");
        }
    }
}
