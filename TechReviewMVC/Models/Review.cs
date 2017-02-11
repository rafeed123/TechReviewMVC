using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechReviewMVC.Models
{
    public class Review
    {
        [Key]
        public int ID { get;  set;}
        public string Device { get; set ; }
        public string Description { get; set; }
        public string FullDescription { get; set; }
        //[Display(FullDescription ="Item Description")] Would like to have FullDescription display Item Description with a space
        public string Price { get; set; }
        public DateTime ManufactureDate { get; set; }
        //Foreign Key will setup Maufacturer Category
        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

    }
}