using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCSample.Models
{
    public class Movies
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Genre Genre { get; set; }
        [Required]
        public int GenreId { get; set; }
        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }
        [Display(Name = "Release Added")]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Number In Stock")]
        public byte NumberInStock { get; set; }
        public byte NumberAvailable { get; set; }
    }
}