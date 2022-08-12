using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Entity
{
    public class DataContext : DbContext
    {
        public DataContext() : base("dataConnection")
        {
            Database.SetInitializer(new DataInitializer());
        }

        public DbSet<Product> Products { get; set; } //veritabanındaki tablonun adı Products
        public DbSet<Category> Categories { get; set; }  //veritabanındaki tablonun adı Categories

        public DbSet<Review> Reviews { get; set; }
    }
}