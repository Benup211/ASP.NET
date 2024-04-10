using System.ComponentModel.DataAnnotations;
namespace lab6.Models
{
    public class Model1Model
    {
        [Required(ErrorMessage = "Please enter your full name")]
        [StringLength(100, MinimumLength = 5)]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your Salary")]
        public int Salary { get; set; }
    }
}