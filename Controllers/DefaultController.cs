using System.Linq;
using System.Web.Mvc;
using WebApplication1.Entity;
using Microsoft.AspNet.Identity;



namespace WebApplication1.Controllers
{
    public class DefaultController : Controller
    {
        DataContext db = new DataContext();

       

        // GET: Default
        public ActionResult Index()
        {
            return View(db.Products.ToList());

        }

        [Route("Home")]
        public ActionResult Home()
        {
            return View();
        }
       
        public ActionResult Shop()
        {
            return View(db.Products.ToList());
        }
        
        public ActionResult ShopDetail(int id)
        {
            
            return View(db.Products.Where(i=>i.id==id).FirstOrDefault());
        }

        



        [HttpPost]
        public ActionResult VeriAl(FormCollection datas)
        {
           
            var value1=datas["txtValue1"].ToString();
            var value2 = datas["txtValue2"].ToString();
            var value3 = datas["txtValue3"].ToString();
           
          

            return View();
        }





        public ActionResult ShoppingCart()
        {
            return View();
        }
        [Route("Checkout")]
        public ActionResult Checkout()
        {
            return View();
        }
        [Route("Contact")]
        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult ProductList(int id)
        {
            return View(db.Products.Where(i=>i.CategoryID==id).ToList());
        }

        public ActionResult Searchh(string q)
        {
            var p = db.Products.Where(i => i.IsApproved == true);
            if (!string.IsNullOrEmpty(q))
            {

                p = p.Where(i => i.ProductName.Contains(q) || i.Description.Contains(q));

            }
            return View(p.ToList());
        }

      
    }
}