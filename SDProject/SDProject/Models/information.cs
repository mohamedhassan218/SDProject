using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SDProject.Models
{
    public class information
    {
        [Required(ErrorMessage ="Please enter your first name.")]
        public String FName { set; get; }
        [Required(ErrorMessage ="Please enter your last name.")]
        public String LName { set; get; }
        [Required(ErrorMessage ="Please enter your address.")]
        public String Address { set; get; }
        [RegularExpression(@"^\d+$", ErrorMessage ="Please enter the family size.")]
        public int FamilySize { set; get; }
        [ForeignKey("CaseInspectorId")]
        public int InspectorId { set; get; }
        [RegularExpression(@"^\d+$", ErrorMessage = "Please enter the age in years.")]
        public int Age { set; get; }
        [Required(ErrorMessage ="You must choose the gender.")]
        public bool IfMale { set; get; }
        public String PhoneNumber { set; get; }
        [Required(ErrorMessage = "Please enter the monthly earning.")]
        public float MonthlyEarning { set; get; }
    }
}
