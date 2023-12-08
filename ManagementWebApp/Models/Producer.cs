using ManagementWebApp.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace ManagementWebApp.Models
{
    public class Producer : IEntityBase
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture URL")]
        [Required(ErrorMessage = "Profile Picture is Required")]
        public string profilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "FullName is Required")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is Required")]
        public string Bio { get; set; }

        //Relationships
        public List<Movie>? Movies { get; set; }

    }
}
