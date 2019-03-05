using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GETForms.Web.Models
{
    public class FilmSearch
    {
        [Display(Name="Genre: ")]
        public string Genre { get; set; }

        [Display(Name = "Minimum Length: ")]
        public int? MinLength { get; set; }

        [Display(Name = "Maximum Length: ")]
        public int? MaxLength { get; set; }

        public IList<Film> FilmResults { get; set; }

        public static List<SelectListItem> GenreTypes = new List<SelectListItem>
        {
            new SelectListItem() { Text = "Action", Value = "Action" },
            new SelectListItem() { Text = "Animation", Value = "Animation" },
            new SelectListItem() { Text = "Children", Value = "Children" },
            new SelectListItem() { Text = "Classics", Value = "Classics" },
            new SelectListItem() { Text = "Comedy", Value = "Comedy" },
            new SelectListItem() { Text = "Documentary", Value = "Documentary" },
            new SelectListItem() { Text = "Drama", Value = "Drama" },
            new SelectListItem() { Text = "Family", Value = "Family" },
            new SelectListItem() { Text = "Foreign", Value = "Foreign" },
            new SelectListItem() { Text = "Games", Value = "Games" },
            new SelectListItem() { Text = "Horror", Value = "Horror" },
            new SelectListItem() { Text = "Music", Value = "Music" },
            new SelectListItem() { Text = "New", Value = "New" },
            new SelectListItem() { Text = "Sci-Fi", Value = "Sci-Fi" },
            new SelectListItem() { Text = "Sports", Value = "Sports" },
            new SelectListItem() { Text = "Travel", Value = "Travel" }
        };
    }
}
