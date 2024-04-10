using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace  EFNET.Models
{
    public class WebUser
    {
        [Column("UserID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }
        [Display(Name = "User Name")]
        [Required(ErrorMessage = "User Name is required")]
        [StringLength(50)]
        public string? UserName { get; set; }
        [Required]
        [StringLength(25,MinimumLength = 3,ErrorMessage="You must enter minimum 3 characters")]
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
    }
    
}