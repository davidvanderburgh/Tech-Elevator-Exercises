using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GETForms.Web.DAL;
using GETForms.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace GETForms.Web.Controllers
{
    public class CustomersController : Controller
    {
        private ICustomerDAL dal;

        public CustomersController(ICustomerDAL dal)
        {
            this.dal = dal;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SearchResult(CustomerSearch model)
        {
            model.SearchResults = dal.SearchForCustomers(model.SearchString, model.SortString);
            return View(model);
        }
    }
}