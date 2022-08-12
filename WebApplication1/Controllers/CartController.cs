using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Entity;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
  
    public class CartController : Controller
    {
        DataContext db = new DataContext();
        // GET: Cart
        public ActionResult Index()
        {
            return View(GetCart());
        }


  


        public ActionResult CheckOut()
        {
            return View(new ShippingDetails());
        }
        [HttpPost]
        public ActionResult CheckOut(ShippingDetails model)
        {
            var cart = GetCart();
            if (cart.CartLines.Count == 0)
            {
                ModelState.AddModelError("Ürün Yok","Sepetinizde Ürün Bulunmamaktadır.");
            }
            if (ModelState.IsValid)//spariş verince ürün temizle dedim dön
            {
                
                cart.Clear(); 
                return View("SiparisTamamlandı");
            }
            else
            {
                return View(model);
            }
            
        }
        public PartialViewResult Summary()
        {
            return PartialView(GetCart());
        }

        public ActionResult RemoveFromCart(int Id)
        {
            var product = db.Products.FirstOrDefault(i => i.id == Id);
            if (product != null)
            {
                GetCart().DeleteProduct(product);
            }
            return RedirectToAction("Index");
        }


        public ActionResult AddToCart(int Id)
        {
            var product = db.Products.FirstOrDefault(i => i.id == Id);
            if (product != null)
            {
                GetCart().AddProduct(product, 1);//kullanıcı tek seferde 1 tane eklemesi lazım dene 
            }

            return RedirectToAction("Index");
        }

        public Cart GetCart()
        {
            var cart = (Cart)Session["Cart"];
            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        }
    }
}