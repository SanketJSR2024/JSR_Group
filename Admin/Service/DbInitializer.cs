using Admin.Service.IService;
using Common;
using DataAcesss.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Service
{
    public class DbInitializer : IDbInitializer
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;


        public DbInitializer(ApplicationDbContext db, UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public async Task Initalize()
        {
            try
            {
                if (_db.Database.GetPendingMigrations().Count() > 0)
                {
                    _db.Database.Migrate();
                }
            }
            catch (Exception)
            {

            }

            if (_db.Roles.Any(x => x.Name == SD.Role_SuperAdmin)) return;

            _roleManager.CreateAsync(new IdentityRole(SD.Role_SuperAdmin)).GetAwaiter().GetResult();
            _roleManager.CreateAsync(new IdentityRole(SD.Role_Admin)).GetAwaiter().GetResult();
            _roleManager.CreateAsync(new IdentityRole(SD.Role_Customer)).GetAwaiter().GetResult();
            _roleManager.CreateAsync(new IdentityRole(SD.Role_Employee)).GetAwaiter().GetResult();

            var newUser = new ApplicationUser
            {
                FirstName = "Sanket",
                LastName = "Thakkar",
                UserName = "superadmin@jsr.com",
                Email = "superadmin@jsr.com",
                EmailConfirmed = true,
                PhoneNumber = "9884565415",
                PhoneNumberConfirmed = false,
                Discriminator = "-"
            };

            var result = await _userManager.CreateAsync(newUser, "Jsr@2024");

            IdentityUser user = await _db.Users.FirstOrDefaultAsync(u => u.Email == "superadmin@jsr.com");
            _userManager.AddToRoleAsync(user, SD.Role_SuperAdmin).GetAwaiter().GetResult();

            // Create Demo Company
            var company = new Company
            {
                CompanyName="Gujarat Solar",
                Description="It's Solar Brand",
                OwnerName="Radha P. Patel"
            };

            await _db.Company.AddAsync(company);
            await _db.SaveChangesAsync();

            if (company.Id > 0)
            {
                // Create Demo Software Register
                var software = new CompanySoftware
                {
                    CompanyId = company.Id,
                    SoftwareKey = "8895dfadwesavasdfasdfasdasdfadsfasdfasd",
                    CompanySectionName="Dept1",
                    IsActive=true,
                };

                await _db.CompanySoftware.AddAsync(software);
                await _db.SaveChangesAsync();

                // Create Admin for Company Software
                var compAdmin = new ApplicationUser
                {
                    FirstName = "Om",
                    LastName = "Patel",
                    UserName = "ompatel_admin@jsr.com",
                    Email = "ompatel_admin@jsr.com",
                    EmailConfirmed = true,
                    PhoneNumber = "7958465015",
                    PhoneNumberConfirmed = true,
                    Discriminator = "-"
                };

                var resultAdmin = await _userManager.CreateAsync(compAdmin, "Patel@2024");

                var adminUser = _db.Users.FirstOrDefault(u => u.Email == "ompatel_admin@jsr.com");
                _userManager.AddToRoleAsync(adminUser, SD.Role_Admin).GetAwaiter().GetResult();

                var AdminData = new CompanyAdmin
                {
                    SoftwareId = software.Id,
                    IsActive = true,
                    UserId = adminUser.Id,
                };

                await _db.CompanyAdmin.AddAsync(AdminData);
                await _db.SaveChangesAsync();


                // Create 2 Employee for created company
                var newEmployee1 = new ApplicationUser
                {
                    FirstName = "Shah Rukh",
                    LastName = "Khan",
                    UserName = "shahrukh_0011@jsr.com",
                    Email = "shahrukh_0011@jsr.com",
                    EmailConfirmed = true,
                    PhoneNumber = "7958465015",
                    PhoneNumberConfirmed = true,
                    Discriminator = "-"
                };

                var resultEmp1 = await _userManager.CreateAsync(newEmployee1, "Khan@2024");

                var emp1 = _db.Users.FirstOrDefault(u => u.Email == "shahrukh_0011@jsr.com");
                _userManager.AddToRoleAsync(emp1, SD.Role_Employee).GetAwaiter().GetResult();

                var Emp1Data = new CompanyEmployee
                {
                    SoftwareId = software.Id,
                    IsActive=true,
                    UserId = emp1.Id,
                };

                await _db.CompanyEmployee.AddAsync(Emp1Data);
                await _db.SaveChangesAsync();


                var newEmployee2 = new ApplicationUser
                {
                    FirstName = "Vikas",
                    LastName = "Patel",
                    UserName = "vikas_0022@jsr.com",
                    Email = "vikas_0022@jsr.com",
                    EmailConfirmed = true,
                    PhoneNumber = "7996555220",
                    PhoneNumberConfirmed = true,
                    Discriminator = "-"
                };

                var resultEmp2 = await _userManager.CreateAsync(newEmployee2, "Patel@2024");

                var emp2 = _db.Users.FirstOrDefault(u => u.Email == "vikas_0022@jsr.com");
                _userManager.AddToRoleAsync(emp2, SD.Role_Employee).GetAwaiter().GetResult();

                var Emp2Data = new CompanyEmployee
                {
                    SoftwareId = software.Id,
                    IsActive = true,
                    UserId = emp2.Id,
                };

                await _db.CompanyEmployee.AddAsync(Emp2Data);
                await _db.SaveChangesAsync();
            }


        }
    }
}
