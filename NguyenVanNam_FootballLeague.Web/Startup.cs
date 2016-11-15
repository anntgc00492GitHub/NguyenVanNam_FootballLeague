using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using NguyenVanNam_FootballLeague.Web.Models;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenVanNam_FootballLeague.Web.Startup))]
namespace NguyenVanNam_FootballLeague.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateRolesAndUsers();
        }
        private void CreateRolesAndUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));


            // In Startup iam creating first Admin Role and creating a default Admin User   
            if (!roleManager.RoleExists("Admin"))
            {

                // first we create Admin rool  
                var role = new IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);

                //Here we create a Admin super user who will maintain the website                 

                var user = new ApplicationUser();
                user.UserName = "anntgc00492@gmail.com";
                user.Email = "anntgc00492@gmail.com";
                user.EmailConfirmed = true;
                user.LockoutEnabled = true;
                string userPWD = "BaBonBay347";
                user.FullName = "Nguyen Van Nam";
                user.Address = "Hanoi";
                user.UserRole = "Admin";//Viet vao de co trong bang user nhu cac thuoc tinh khac, de phan quyen la role khac, cai nay chi de view

                var chkUser = userManager.Create(user, userPWD);
                //Add default User to Role Admin  
                if (chkUser.Succeeded)
                {
                    var result1 = userManager.AddToRole(user.Id, "Admin");
                }
            }

            // creating Creating Manager role   
            if (!roleManager.RoleExists("Manager"))
            {
                var role = new IdentityRole();
                role.Name = "Manager";
                roleManager.Create(role);
            }
        }
    }
}
