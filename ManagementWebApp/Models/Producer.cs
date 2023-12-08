using ManagementWebApp.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace ManagementWebApp.Models
{
    public class Producer : IEntityBase
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture URL")]
        public string profilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        public string Bio { get; set; }

        //Relationships
        public List<Movie>? Movies { get; set; }

    }
}
