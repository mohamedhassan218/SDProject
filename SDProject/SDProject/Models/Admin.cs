using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace SDProject.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        public string Name { get; set; }
        public string Email{ get; set; }
        public float Salary { get; set; }
    }
}
