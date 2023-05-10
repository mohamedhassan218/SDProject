using System.ComponentModel.DataAnnotations;

namespace SDProject.Models
{
    public class registeration
    {
        [Required (ErrorMessage ="You must enter a name!!")]
        public string FullName { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9]+@[a-zA-Z]+\.com+$", ErrorMessage = "Please enter a valid Email.")]
        public string Email{ get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Salary { get; set; }
    }
}
