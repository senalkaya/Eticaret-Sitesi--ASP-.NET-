using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Entity
{
    public class Category
    {
        public int id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<Product>  Products { get; set; }
    }
}