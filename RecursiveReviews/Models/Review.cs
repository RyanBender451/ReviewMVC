﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RecursiveReviews.Models
{   //Review class
    public class Review
    {
        //The base class review
        [Key]
        public int ReviewID { get; set; }
        public int ReviewScore { get; set; }
        public string ReviewTitle { get; set; }
        public string ReviewAuthor { get; set; }
        public string ReviewContent { get; set; }
        public DateTime ReviewDate { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

    }
}