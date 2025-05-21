using ClassLibrary.Model;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;

namespace WinFormsApp
{
    public partial class Login : Form
    {
        private IServiceProvider serviceProvider;
        private readonly FormsIdentityContext IdentityContext = new FormsIdentityContext();
        private readonly CourseDBContext context;

        public Login()
        {
            InitializeComponent();
            context = new CourseDBContext();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var signInResults = await VerifyUserNamePassword(txtUserName.Text, txtPassword.Text);
            if (signInResults == true)
            {
                MessageBox.Show("Login Successful!"); // Show success message

                Home home = new Home();
                this.Hide();
                home.Show();
            }
            else
            {
                MessageBox.Show("Error. The username or password are not correct");
            }
        }

        public async Task<bool> VerifyUserNamePassword(string userName, string password)
        {
            try
            {
                var services = new ServiceCollection();
                ConfigureServices(services);
                serviceProvider = services.BuildServiceProvider();

                var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();
                var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                var founduser = await userManager.FindByEmailAsync(userName);
                if (founduser == null)
                {
                    MessageBox.Show("No user found with this email.");
                    return false;
                }

                var passCheck = await userManager.CheckPasswordAsync(founduser, password);
                if (!passCheck)
                {
                    LogFailedLogin(userName, "Login Failed - Incorrect Password");
                    return false;
                }

                var user = context.Users.FirstOrDefault(u => u.Email == userName);
                if (user == null)
                {
                    MessageBox.Show("Login succeeded but local user not found.");
                    return false;
                }

                var roles = await userManager.GetRolesAsync(founduser);

                // Store global info
                Global.User = founduser;
                Global.RoleName = roles.FirstOrDefault();
                Global.AllAdmins = await userManager.GetUsersInRoleAsync("Admin");
                Global.AllManagers = await userManager.GetUsersInRoleAsync("Manager");
                Global.AllTechnicicans = await userManager.GetUsersInRoleAsync("Technician");
                Global.AllUsers = await userManager.GetUsersInRoleAsync("User");
                Global.Email = user.Email;
                // Log success with a fresh DbContext and await it
                //try
                //{
                //    await Task.Run(async () =>
                //    {
                //        using (var logContext = new CourseDBContext())
                //        {
                //            var userToLog = logContext.Users.FirstOrDefault(u => u.Email == userName);
                //            if (userToLog != null)
                //            {
                //                // Create log with explicit timestamp using non-nullable DateTime value
                //                var timestamp = new DateTime(DateTime.Now.Ticks);

                //                Log log = new Log
                //                {
                //                    Action = "Login Successful",
                //                    UserId = userToLog.UserId,
                //                    TimeStamp = timestamp,
                //                    CurrentValue = "N/A",
                //                    OriginalValue = "N/A",
                //                    EntityChanged = "LoginAttempt"
                //                };

                //                logContext.Logs.Add(log);
                //                await logContext.SaveChangesAsync();
                //                Console.WriteLine("Log entry saved successfully.");
                //            }
                //            else
                //            {
                //                Console.WriteLine("User not found in log context.");
                //            }
                //        }
                //    });
                //}
                //catch (Exception ex)
                //{
                //    var baseEx = ex;
                //    while (baseEx.InnerException != null) baseEx = baseEx.InnerException;
                //    MessageBox.Show("Error logging login success: " + baseEx.Message);
                //}


                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error during login: " + ex.Message);
                return false;
            }
        }

        private void LogFailedLogin(string email, string reason)
        {
            //try
            //{
            //    var user = context.Users.FirstOrDefault(u => u.Email == email);
            //    if (user != null)
            //    {
            //        // Create log with explicit timestamp using non-nullable DateTime value
            //        var timestamp = new DateTime(DateTime.Now.Ticks);

            //        Log log = new Log
            //        {
            //            Action = reason,
            //            UserId = user.UserId,
            //            TimeStamp = timestamp,
            //            CurrentValue = "N/A",
            //            OriginalValue = "N/A",
            //            EntityChanged = "LoginAttempt"
            //        };

            //        context.Logs.Add(log);
            //        context.SaveChanges();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error logging failed login: " + ex.Message);
            //}
        }

        private void ConfigureServices(IServiceCollection services)
        {
            try
            {
                services.AddEntityFrameworkSqlServer()
                    .AddDbContext<FormsIdentityContext>();

                services.AddIdentity<IdentityUser, IdentityRole>()
                   .AddEntityFrameworkStores<FormsIdentityContext>()
                   .AddDefaultTokenProviders();

                services.AddLogging();
                services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error configuring services: " + ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
