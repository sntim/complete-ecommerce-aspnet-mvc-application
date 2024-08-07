﻿using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor:Data.Base.IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture URL")]
        [Required(ErrorMessage = "Profile picture is required")]

        public string ProfilePicture { get; set; }
        

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage ="Full Name must be between 3 and 50 chars")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]
        public string Bio { get; set; }

        //Relationships
        public List<Actor_Movie>? Actor_Movies { get; set; }
    }
}
