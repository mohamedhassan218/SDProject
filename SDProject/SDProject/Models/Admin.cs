using System.ComponentModel.DataAnnotations;

namespace SDProject.Models
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email{ get; set; }
        [Required]
        public float Salary { get; set; }

    }
}
