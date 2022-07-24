﻿using eTickets.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Image")]
        public string ImageURL { get; set; }
        public double Price { get; set; }
        public DateTime StartDate{ get; set; }
        public DateTime EndDate { get; set; }
        
        public int CinemaId { get; set; }
        public int ProducerId { get; set; }

        public MovieCategory MovieCategory { get; set; }
        public List<Actors_Movies> Actors_Movies { get; set; }

        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }
    }
}
