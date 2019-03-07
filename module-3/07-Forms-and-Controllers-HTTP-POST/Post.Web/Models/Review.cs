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

        [Display(Name="User Name")]
        public string Username { get; set; }

        [Display(Name = "Rating")]
        public int Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                if (value > 5)
                {
                    value = 5;
                }
                else if (value < 1)
                {
                    value = 1;
                }
                _rating = value;
            }
        }

        [Display(Name = "Review Title")]
        public string ReviewTitle { get; set; }

        [Display(Name = "Review Text")]
        public string ReviewText { get; set; }
    }
}
