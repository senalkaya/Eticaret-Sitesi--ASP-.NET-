using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Entity;
using WebApplication1.Models;
using System.Data;
using System.Data.Entity;

namespace WebApplication1.Controllers
{
    
    public class RewievController : Controller
    {
        ReviewContext db = new ReviewContext();

        // GET: Rewiev
        public ActionResult Index()
        {
            return View();
        }



    }
}