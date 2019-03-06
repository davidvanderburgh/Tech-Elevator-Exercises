using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Post.Web.DAL;
using Post.Web.Models;

namespace Post.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IReviewDAL dal;

        public HomeController(IReviewDAL dal)
        {
            this.dal = dal;
        }

        // GET: Home
        public ActionResult Index()
        {
            return View(dal.GetAllReviews());
        }        

        [HttpGet]
        public IActionResult NewReview()
        {

            Review review = new Review();
            
            return View(review);
        }

        [HttpPost]
        public IActionResult NewReview(Review model)
        {
            dal.SaveReview(model);
            return RedirectToAction("Index", "Home");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
