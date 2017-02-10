using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TechReviewMVC.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Manufacturer { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}