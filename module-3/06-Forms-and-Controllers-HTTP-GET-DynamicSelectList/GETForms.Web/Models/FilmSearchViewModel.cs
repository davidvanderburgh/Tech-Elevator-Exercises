using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace GETForms.Web.Models
{
    public class FilmSearchViewModel
    {
        public string SelectedGenre { get; set; }
        public IEnumerable<SelectListItem> Genres { get; set; }
    }
}