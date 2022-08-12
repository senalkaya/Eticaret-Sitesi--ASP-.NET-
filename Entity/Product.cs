using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Entity
{
    public class Product
    {

        public int id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public double Price{ get; set; }
        public int Stock { get; set; }
        public bool Slider { get; set; }
        public bool IsHome { get; set; }
        public int IsFeatured { get; set; }
        public bool IsApproved { get; set; }
        public int CategoryID { get; set; }
        //public string YorumPro { get; set; }
        public Category Category { get; set; }
        //public Review Review { get; set; }
       

    }
}