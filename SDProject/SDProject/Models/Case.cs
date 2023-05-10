using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SDProject.Models
{
    public class Case
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public int FamilySize { get; set; }
        public float MonthlyEarnings { get; set; }
        public string Dieseases { get; set; }
        public string GeneralNotes { get; set; }
        public int ReportId { get; set; }
        public int CaseInspectorId { get; set; }
    }
}
