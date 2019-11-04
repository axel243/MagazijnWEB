using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTest.Models;

namespace WebTest.Interfaces
{
    
        public interface IProductRepository
        {
            void Add(ProductModel p);
            void Edit(ProductModel p);
            void Remove(int Id);
            IEnumerable<Product> GetProducts();
            Product FindById(int Id);
        }
    }


