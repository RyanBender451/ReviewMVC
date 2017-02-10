using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecursiveReviews.Models
{
    public class Review
    {
        public int ReviewID { get; set; }
        public int ReviewScore { get; set; }
        public string ReviewTitle { get; set; }
        public string ReviewAuthor { get; set; }
        public string ReviewContent { get; set; }
        public DateTime ReviewDate { get; set; }

    }
}