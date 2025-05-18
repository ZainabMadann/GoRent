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