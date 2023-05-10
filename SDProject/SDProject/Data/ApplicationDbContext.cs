using Microsoft.EntityFrameworkCore;
using SDProject.Models;
namespace SDProject.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<CaseInspector> caseInspectors { get; set; }
    }
}
