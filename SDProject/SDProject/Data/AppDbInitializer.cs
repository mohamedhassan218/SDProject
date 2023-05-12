using SDProject.Models;

namespace SDProject.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.EnsureCreated();

                if (!context.Admins.Any())
                {
                    context.Admins.AddRange(new List<Admin>
                    {
                        new Admin()
                        {
                            Name = "Ahmed Belhaj",
                            Email = "admin1@charity.com",
                            Salary = 2200
                        },
                        new Admin()
                        {
                            Name = "Ahmed Sayed Zizo",
                            Email = "admin2@charity.com",
                            Salary = 4000
                        },
                        new Admin()
                        {
                            Name = "Ferjani Sassi",
                            Email = "admin3@charity.com",
                            Salary = 3000
                        },
                        new Admin()
                        {
                            Name = "Achraf Ben Charki﻿",
                            Email = "admin4@charity.com",
                            Salary = 3000
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
