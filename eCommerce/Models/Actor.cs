﻿using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace eCommerce.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Profile Picure")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        public string Bio { get; set; }


        //Relationships

        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
