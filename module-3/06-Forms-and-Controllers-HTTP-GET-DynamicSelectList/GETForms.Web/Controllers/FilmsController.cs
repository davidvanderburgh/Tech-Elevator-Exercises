using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GETForms.Web.DAL;
using GETForms.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GETForms.Web.Controllers
{
    public class FilmsController : Controller
    {
        private readonly IFilmDAL _filmDal;

        public FilmsController(IFilmDAL filmDal)
        {
            _filmDal = filmDal;
        }

        /// <summary>
        /// The request to display an empty search page.
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpGet]
        public ActionResult Index()
        {
            var model = new FilmSearchViewModel();
            var genreItems = new List<SelectListItem>();

            foreach(string genre in _filmDal.GetGenres())
            {
                genreItems.Add(new SelectListItem { Text = genre });
            }
            model.Genres = genreItems;

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(string selectedGenre)
        {
            return Content(selectedGenre);
        }

        /// <summary>
        /// Receives the search result request and goes to th database looking for the information.
        /// </summary>
        /// <param name="request">A request model that contains the search parameters.</param>
        /// <returns></returns>
        public ActionResult SearchResult(/*FilmSearch request */)
        {
            /* Call the DAL and pass the values as a model back to the View */
            return null;
        }
    }
}