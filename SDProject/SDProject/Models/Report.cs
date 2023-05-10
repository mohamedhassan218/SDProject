using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SDProject.Models
{
    public class Report
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("CaseId")]
        public int CaseId { get; set; }
        [Required(ErrorMessage ="Please choose if the data is valid or not.")]
        public bool IfDataValid { get; set; }
        [Required(ErrorMessage ="Enter the type of case.")] 
        public string TypeOfCase { get; set; }
        public string FinalConclusion { get; set; }

    }
}
