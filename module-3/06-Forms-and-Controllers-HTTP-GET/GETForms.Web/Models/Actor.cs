using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GETForms.Web.Models
{
    public class Actor
    {
        /// <summary>
        /// The first name to search for.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name to search for.
        /// </summary>
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
    }
}
