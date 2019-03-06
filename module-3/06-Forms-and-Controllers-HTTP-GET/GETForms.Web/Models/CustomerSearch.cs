using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GETForms.Web.Models
{
    public class CustomerSearch
    {
        [Display(Name = "First Name: ")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name: ")]
        public string LastName { get; set; }

        [Display(Name = "Name: ")]
        public string SearchString { get; set; }

        [Display(Name = "Order By: ")]
        public string SortString { get; set; }

        public IList<Customer> SearchResults { get; set; }

        public static IList<SelectListItem> SortMethods = new List<SelectListItem>
        {
            new SelectListItem("Last Name", "last_name"),
            new SelectListItem("Email", "email"),
            new SelectListItem("Active", "activebool")
        };
    }
}
