using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using ClassLibrary.Model;
using Microsoft.AspNetCore.Identity; // Ensure this matches your actual namespace

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllersWithViews();

// Register your DbContext and provide the connection string from appsettings.json
builder.Services.AddDbContext<CourseDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// ✅ Add session support BEFORE builder.Build()
builder.Services.AddSession();

// ✅ Add this to support @inject IHttpContextAccessor in Razor views
builder.Services.AddHttpContextAccessor();

var app = builder.Build();

// Seed the admin user
SeedAdminAndManagerUsers(app);

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseSession(); // Use session middleware

app.UseAuthorization();

// Define default route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

void SeedAdminAndManagerUsers(WebApplication app)
{
    using var scope = app.Services.CreateScope();
    var db = scope.ServiceProvider.GetRequiredService<CourseDBContext>();

    var passwordHasher = new PasswordHasher<User>();

    // Seed Admin
    if (!db.Users.Any(u => u.Role == "Admin"))
    {
        var admin = new User
        {
            Name = "Admin",
            Email = "admin@site.com",
            Role = "Admin"
        };
        admin.Password = passwordHasher.HashPassword(admin, "admin123");
        db.Users.Add(admin);


        var eqStatus = new EquipmentStatus
        {
            Name = "Available",
            Description = "Equipment is Available"
        };

        var eqStatus2 = new EquipmentStatus
        {
            Name = "Rented",
            Description = "Equipment is Rented"
        };

        db.EquipmentStatuses.Add(eqStatus);
        db.EquipmentStatuses.Add(eqStatus2);



        var reqStatus = new RequestStatus
        {
            Name = "Pending",
            Description = "Request is Pending"
        };

        var reqStatus2 = new RequestStatus
        {
            Name = "Approved",
            Description = "Request is Approved"
        };

        var reqStatus3 = new RequestStatus
        {
            Name = "Rejected",
            Description = "Request is Rejected"
        };

        var reqStatus4 = new RequestStatus
        {
            Name = "Returned",
            Description = "Request is Returned"
        };

        db.RequestStatuses.Add(reqStatus);
        db.RequestStatuses.Add(reqStatus2);
        db.RequestStatuses.Add(reqStatus3);
        db.RequestStatuses.Add(reqStatus4);



        var eqCondition = new EquipmentCondition
        {
            Name = "New",
            Description = "Equipment is New"
        };

        var eqCondition2 = new EquipmentCondition
        {
            Name = "Used",
            Description = "Equipment is Used"
        };

        var eqCondition3 = new EquipmentCondition
        {
            Name = "Damaged",
            Description = "Equipment is Damaged"
        };

        db.EquipmentConditions.Add(eqCondition);
        db.EquipmentConditions.Add(eqCondition2);
        db.EquipmentConditions.Add(eqCondition3);



    }

    // Seed Manager
    if (!db.Users.Any(u => u.Role == "Manager"))
    {
        var manager = new User
        {
            Name = "Manager",
            Email = "manager@site.com",
            Role = "Manager"
        };
        manager.Password = passwordHasher.HashPassword(manager, "manager123");
        db.Users.Add(manager);
    }

    


    db.SaveChanges();
}