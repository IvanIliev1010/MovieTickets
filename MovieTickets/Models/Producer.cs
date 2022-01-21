﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTickets.Models
{
    public class Producer
    {
        [Key]
        public int ProducerId { get; set; }

        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Biograhpy { get; set; }

        // relatioships for the Database
        public List <Movie> Movies { get; set; }
    }
}
