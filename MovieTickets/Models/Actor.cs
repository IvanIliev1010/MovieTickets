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
        [Required(ErrorMessage ="A picture Url is required")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "The name of the actor is required")]
        [StringLength(60, MinimumLength = 3, ErrorMessage ="Actor's name nust be between 3 and 60 charecters long!")]
        public string FullName { get; set; }
        [Display(Name = "Actor Bio")]
        [Required(ErrorMessage = "Actor biography is required")]
        public string  Biograhpy { get; set; }

        // relationships for the database
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
