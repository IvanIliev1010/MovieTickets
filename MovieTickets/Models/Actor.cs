using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTickets.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }
        [Display(Name ="Picture")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Name")]
        public string FullName { get; set; }
        [Display(Name = "Actor Bio")]
        public string  Biograhpy { get; set; }

        // relationships for the database
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
