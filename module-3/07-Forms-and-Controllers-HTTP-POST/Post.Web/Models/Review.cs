using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Post.Web.Models
{
    public class Review
    {
        private int _rating;

        [Required(ErrorMessage ="*")]
        [Display(Name="User Name")]
        public string Username { get; set; }

        [Required(ErrorMessage = "*")]
        [Range(1,5, ErrorMessage = "Stars must be between 1 and 5")]
        [Display(Name = "Rating")]
        public int Rating { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Review Title")]
        public string ReviewTitle { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Review Text")]
        public string ReviewText { get; set; }
    }
}
