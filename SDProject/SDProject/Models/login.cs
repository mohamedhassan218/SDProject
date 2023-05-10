using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SDProject.Models
{
    public class login
    {
        [Key]
        public int id { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9]+@[a-zA-Z]+\.com+$",ErrorMessage ="Not Valid Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Enter The Passward")]
        public string Passward { get; set; }
    }
}
