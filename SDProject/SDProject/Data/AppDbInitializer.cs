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
                            Email = "admin1@charity.com"
                        },
                        new Admin()
                        {
                            Name = "Ahmed Zizo",
                            Email = "admin2@charity.com"
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
