using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Post.Web.Models
{
    public class Review
    {
        [Display(Name="User Name")]
        public string Username { get; set; }

        [Display(Name = "Rating")]
        public int Rating { get; set; }

        [Display(Name = "Review Title")]
        public string ReviewTitle { get; set; }

        [Display(Name = "Review Text")]
        public string ReviewText { get; set; }
    }
}
