using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; }

        [Display(Name = "Profile Picture")]
        public string ProfilePicture { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        public string Bio { get; set; }

        //Relationshiips
        public List<Movie> Movies { get; set; }
    }
}
