using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class DetailReview
    {
        public int id { get; set; }
        public string Yorum { get; set; }
        public string Name { get; set; }
        public string Eposta { get; set; }
    }
}