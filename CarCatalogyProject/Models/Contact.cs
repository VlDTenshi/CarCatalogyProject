using System.ComponentModel.DataAnnotations;

namespace CarCatalogyProject.Models
{
    public class Contact
    {
        [Display(Name= "Insert a name")]
        [Required(ErrorMessage = "You have to insert a name")]
        public string Name { get; set; }
        [Display(Name = "Insert a surname")]
        [Required(ErrorMessage = "You have to insert a surname")]
        public string Surname { get; set; }
        [Display(Name = "Insert an age")]
        [Required(ErrorMessage = "You have to insert an Age")]
        public int Age { get; set; }
        [Display(Name = "Insert an Email")]
        [Required(ErrorMessage = "You have to insert an Email")]
        public string Email { get; set; }
        [Display(Name = "Insert an Message")]
        [Required(ErrorMessage = "You have to insert an Message")]
        [StringLength(30, ErrorMessage = "Text should be not less than 30 characters")]
        public string Message { get; set; }
    }
}
