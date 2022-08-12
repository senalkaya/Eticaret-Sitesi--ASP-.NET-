using System.Collections.Generic;
using System.Data.Entity;

namespace WebApplication1.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {

        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category() {CategoryName="Camera",Description="kamera açıklaması"},
                new Category() {CategoryName="Dress",Description="dres açıklaması"},
                new Category() {CategoryName="Shirt",Description="shirt açıklaması"},
                new Category() {CategoryName="Jeans",Description="jeans açıklaması"},
                new Category() {CategoryName="Swim wear",Description="swim wear açıklaması"},
                new Category() {CategoryName="Sport wear",Description="sport wear açıklaması"},
                new Category() {CategoryName="Jump suits",Description="jump suit açıklaması"},
                new Category() {CategoryName="Blazers",Description="blazers açıklaması"},
                new Category() {CategoryName="Jackets",Description="jacket açıklaması"},
                new Category() {CategoryName="Shoes",Description="shoes açıklaması"}
            };
            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

            var urunler = new List<Product>()
            {
                new Product() {ProductName="Camera",Description="kamera ürünü açıklaması",Price=6500,Stock=120,IsHome=true,IsApproved=true,IsFeatured=1,Slider=true,CategoryID=1,Image="product-1.jpg"},
                new Product() {ProductName="Sweater",Description="kazak ürün açıklaması",Price=330,Stock=172,IsHome=false,IsApproved=true,IsFeatured=2,Slider=true,CategoryID=2,Image="product-2.jpg"},
                new Product() {ProductName="Lampshade",Description="abajur ürün açıklaması",Price=750,Stock=93,IsHome=false,IsApproved=true,IsFeatured=1,Slider=true,CategoryID=6,Image="product-3.jpg"},
                new Product() {ProductName="Shoes",Description="ayakkabıların ürün açıklaması",Price=630,Stock=110,IsHome=false,IsApproved=true,IsFeatured=2,Slider=true,CategoryID=3,Image="product-4.jpg"},
                new Product() {ProductName="Drone",Description="drone ürün açıklaması",Price=1200,Stock=30,IsHome=false,IsApproved=true,IsFeatured=2,Slider=true,CategoryID=1,Image="product-5.jpg"},
                new Product() {ProductName="Watch",Description="saat ürün açıklaması",Price=7200,Stock=182,IsHome=false,IsApproved=true,IsFeatured=1,Slider=true,CategoryID=4,Image="product-6.jpg"},
                new Product() {ProductName="Blowse",Description="buluz ürün açıklaması",Price=240,Stock=143,IsHome=false,IsApproved=true,IsFeatured=1,Slider=true,CategoryID=2,Image="product-7.jpg"},
                new Product() {ProductName="Hair care set",Description="saç bakım ürünleri açıklaması",Price=320,Stock=143,IsHome=false,IsApproved=true,IsFeatured=1,Slider=true,CategoryID=12,Image="product-8.jpg"},
                new Product() {ProductName="Office chair",Description="ofis koltuğu açıklaması",Price=650,Stock=120,IsHome=false,IsApproved=true,IsFeatured=2,Slider=true,CategoryID=13,Image="product-9.jpg"}
            };
            



            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();



           /* var yorumlar = new List<Review>()
            {
                new Review(){Id=2,Name="sena",Email="senalkayaa@gmail.com",Yorum="ürün yorumu"},
                new Review(){Id=4,Name="sena",Email="senalkayaa@gmail.com",Yorum="ürün yorumu2"},
                new Review(){Id=4,Name="cagan",Email="caganalkaya@gmail.com",Yorum="ürün yorumu c"},
                new Review(){Id=6,Name="cagan",Email="caganalkaya@gmail.com",Yorum="ürün yorumu c2"}
            };


            foreach (var yorum in yorumlar)
            {
                context.Reviews.Add(yorum);
            }
            context.SaveChanges();*/


            base.Seed(context);

        }


    }
}