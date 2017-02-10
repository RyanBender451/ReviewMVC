using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecursiveReviews.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Place { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}