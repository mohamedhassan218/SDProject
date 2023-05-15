using Microsoft.EntityFrameworkCore;
using SDProject.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SDProject.Models
{
    public class Case
    {
        [Key]
        [Display(Name = "Case Id")]
        public int CaseId { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public int FamilySize { get; set; }
        [Required]
        [Display(Name = "Age")]
        public int Age { get; set; }
        [Required]
        public Gender CaseGender { get; set; }
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
