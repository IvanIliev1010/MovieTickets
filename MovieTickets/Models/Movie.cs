using MovieTickets.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTickets.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Descripiton { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndtDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

        //relationships for the database
        public List<Actor_Movie> Actors_Movies { get; set; }

        // relations with the Cinema - ONE-TO-MANY
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        //Producer - ONE-TO-MANY
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }
        public DateTime EndDate { get; internal set; }
    }
}
