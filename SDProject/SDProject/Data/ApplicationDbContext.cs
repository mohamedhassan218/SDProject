using Microsoft.EntityFrameworkCore;
using SDProject.Models;
namespace SDProject.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<login> logins { get; set; }
        public DbSet<registeration> registerations { get; set; }
        public DbSet<information> information { get; set; }
        public DbSet<CaseInspector> inspectors { get; set; }
        public DbSet<Report> reports { get; set; }
        public DbSet<Admin> admins { get; set; }
        public DbSet<Case> cases { get; set; }
    }
}
