using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebTest.Interfaces;
using System.Data.Entity;
using WebTest.Models;

namespace WebTest.Repos
{
    public class ProductRepository 
    {
        private MagazijnEntities context = new MagazijnEntities();

        public void Add(ProductModel p)
        {
            context.Products.Add(new Product
            {
                Name = p.Name
            }) ;
            context.SaveChanges();
        }

        public void Edit(ProductModel model)
        {
            var entity = context.Products.Single(p => p.ProductID == model.ProductID);
            entity.Name = model.Name;
            context.SaveChanges();
        }

        public Product FindById(int ID)
        {
            return context.Products.Single(v => v.ProductID == ID);
        }

        public IEnumerable<Product> GetProducts()
        {
            return context.Products.ToList();
        }

        public void Remove(int ID)
        {
            var entity = context.Products.Single(v => v.ProductID == ID);
            context.Products.Remove(entity);
            context.SaveChanges();
        }
    }
}