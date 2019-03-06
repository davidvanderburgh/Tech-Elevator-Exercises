using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GETForms.Web.DAL;
using GETForms.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace GETForms.Web.Controllers
{
    public class FilmsController : Controller
    {
        private IFilmDAL dal;

        public FilmsController(IFilmDAL dal)
        {
            this.dal = dal;
        }

        /// <summary>
        /// The request to display an empty search page.
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Receives the search result request and goes to th database looking for the information.
        /// </summary>
        /// <param name="request">A request model that contains the search parameters.</param>
        /// <returns></returns>
        public ActionResult SearchResult(FilmSearch model)
        {
            /* Call the DAL and pass the values as a model back to the View */

            if (model.MinLength == null)
            {
                model.MinLength = 0;
            }

            if (model.MaxLength == null)
            {
                model.MaxLength = 1000;
            }

            model.FilmResults = dal.GetFilmsBetween(model.Genre, (int)model.MinLength, (int)model.MaxLength);

            return View(model);
        }
    }
}