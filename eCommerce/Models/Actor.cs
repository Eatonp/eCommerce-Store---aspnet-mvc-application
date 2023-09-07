﻿using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace eCommerce.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }


        //Relationships

        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}