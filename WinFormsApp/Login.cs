using ClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace WinFormsApp
{
    public partial class Login : Form
    {
        private IServiceProvider serviceProvider;

        FormsIdentityContext IdentityContext = new FormsIdentityContext();

        CourseDBContext context;
        public Login()
        {
            InitializeComponent();
            context = new CourseDBContext();
        }
        

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var signInResults = await VerifyUserNamePassword(txtUserName.Text, txtPassword.Text);
            if (signInResults == true) //if user is verified
            {
                //do something.. i.e. navigate to next forms
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

                var user = context.Users.FirstOrDefault(u => u.Email == userName);

                bool passCheck = false;

                if (founduser != null)
                {
                    passCheck = await userManager.CheckPasswordAsync(founduser, password);

                    if (passCheck)
                    {
                        var roles = await userManager.GetRolesAsync(founduser);

                        Global.User = founduser;
                        Global.RoleName = roles.FirstOrDefault();
                        Global.AllAdmins = await userManager.GetUsersInRoleAsync("Admin");
                        Global.AllManagers = await userManager.GetUsersInRoleAsync("Manager");
                        Global.AllTechnicicans = await userManager.GetUsersInRoleAsync("Technician");
                        Global.AllUsers = await userManager.GetUsersInRoleAsync("User");

                        // Log successful login
                        if (user != null)
                        {
                            Log log = new Log
                            {
                                Action = "Login Successful",
                                UserId = user.UserId,
                                CurrentValue = "N/A",
                                OriginalValue = "N/A",
                                EntityChanged = "LoginAttempt"
                            };

                            //context.Logs.Add(log);
                            //await context.SaveChangesAsync();
                            Global.Email = user.Email;
                        }
                    }
                    else if (user != null)
                    {
                        // Log failed login (email correct, password wrong)
                        Log log = new Log
                        {
                            Action = "Login Failed - Incorrect Password",
                            UserId = user.UserId,
                            CurrentValue = "N/A",
                            OriginalValue = "N/A",
                            EntityChanged = "LoginAttempt"
                        };

                        context.Logs.Add(log);
                        await context.SaveChangesAsync();
                    }
                }

                return passCheck;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                return false;
            }
        }


        private void ConfigureServices(IServiceCollection services)
        {
            try
            {
                services.AddEntityFrameworkSqlServer()
                    .AddDbContext<FormsIdentityContext>();

                // Register UserManager & RoleManager
                services.AddIdentity<IdentityUser, IdentityRole>()
                   .AddEntityFrameworkStores<FormsIdentityContext>()
                   .AddDefaultTokenProviders();

                // UserManager & RoleManager require logging and HttpContext dependencies
                services.AddLogging();
                services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
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
