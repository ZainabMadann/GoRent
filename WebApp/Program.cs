using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using ClassLibrary.Model; // Ensure this matches your actual namespace

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllersWithViews();

// Register your DbContext and provide the connection string from appsettings.json
builder.Services.AddDbContext<CourseDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// ✅ Add session support BEFORE builder.Build()
builder.Services.AddSession();

var app = builder.Build();

// Seed the admin user
SeedAdminUser(app);

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

// Function to seed an admin user if one doesn't exist
void SeedAdminUser(WebApplication app)
{
    using var scope = app.Services.CreateScope();
    var db = scope.ServiceProvider.GetRequiredService<CourseDBContext>();

    if (!db.Users.Any(u => u.Role == "Admin"))
    {
        var admin = new User
        {
            Name = "Admin",
            Email = "admin@site.com",
            Password = "admin123", // ❗ Replace with hashed password in production
            Role = "Admin"
        };
        db.Users.Add(admin);
        db.SaveChanges();
    }
}
