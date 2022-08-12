using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Entity;

namespace WebApplication1.Models
{
    public class Cart
    {
        private List<CartLine> _cartLines = new List<CartLine>();
        public List<CartLine> CartLines
        {
            get { return _cartLines; }
        }
        public void AddProduct(Product product,int quantity)//ürün ekleme
        {
            var line = _cartLines.FirstOrDefault(i => i.Product.id == product.id);
            if (line == null) //sepette olmayan ürünü sepete ekledim >>kontrol et
            {
                _cartLines.Add(new CartLine()
                {
                    Product = product,
                    Quantity = quantity
                });
            }
            else //eklencek ürün var mı varsa sayısını artır yeni ekleme 
            {
                line.Quantity += quantity;
            }
        }

        public void DeleteProduct(Product product)
        {
            _cartLines.RemoveAll(i => i.Product.id == product.id);
        }


        public double Total()
        {
            return _cartLines.Sum(i => i.Product.Price * i.Quantity);
        }

        public void Clear()
        {
            _cartLines.Clear();
        }

    }

    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}