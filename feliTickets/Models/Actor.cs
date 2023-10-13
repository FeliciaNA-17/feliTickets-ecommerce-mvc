﻿using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using feliTickets.Data.Base;

namespace feliTickets.Models
{
    public class Actor:IEntityBase
    {
        public Actor()
        {
            Actors_Movies = new List<Actor_Movie>();
        }

        [Key]
        public int Id { get; set; }


        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Profile Picture is required")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 chars")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]
        public string Bio { get; set; }

        public List<Actor_Movie> Actors_Movies { get; set; }
        
    }
}
