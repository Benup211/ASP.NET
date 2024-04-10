using System.ComponentModel.DataAnnotations;

namespace net_database.Models{
    public class Model1Model{
        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter an age")]
        public int Age { get; set; }
    }
}