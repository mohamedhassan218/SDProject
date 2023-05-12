using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SDProject.Models
{
    public class Case
    {
        [Key]
        public int CaseId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public int FamilySize { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public bool IfMale { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public float MonthlyEarnings { get; set; }
        public string Dieseases { get; set; }
        public string GeneralNotes { get; set; }

        // Relations:
        // Each case have only one inspector.
        public virtual CaseInspector Inspector { get; set; }
        
        // Each case have can have many reports.
        public virtual ICollection<Report> MyReports { get; set; }
    }
}
