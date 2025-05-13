using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp
{
    public static class Global
    {
        public static IdentityUser User;
        public static string Email { get; set; }
        public static string RoleName;

        public static IEnumerable<IdentityUser> AllAdmins;
        public static IEnumerable<IdentityUser> AllTechnicicans;
        public static IEnumerable<IdentityUser> AllManagers;
        public static IEnumerable<IdentityUser> AllUsers;
    }
}
