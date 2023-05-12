using System.ComponentModel.DataAnnotations;

namespace SDProject.Models
{
    public class CaseInspector
    {
        [Key]
        public int InspectorId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email{ get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public float Salary{ get; set; }

        // Relations:
        public virtual ICollection<Case> Cases { get; set; }

    }
}
