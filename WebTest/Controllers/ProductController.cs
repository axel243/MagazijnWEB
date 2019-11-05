using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTest.Interfaces;
using WebTest.Models;
using WebTest.Repos;

namespace WebTest.Controllers
{
    public class ProductController : Controller
    {

        ProductRepository productRepository = new ProductRepository();
        ProductModel productModel = new ProductModel();

        public ActionResult ShowProducts()
        {
            return View(productRepository.GetProducts());
        }

        public ActionResult ShowProductDetail(int id)
        {
          
            return View(productRepository.FindById(id));
        }

        public ActionResult AddProduct()
        {
            return View(new Product());
        }

        [HttpPost]
        public ActionResult Add(ProductModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            productRepository.Add(model);
            return RedirectToAction("ShowProducts");
        }

        
        [HttpPost]
        public ActionResult EditProduct(ProductModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(productRepository.FindById(model.ProductID));
            }
            productRepository.Edit(model);
            return RedirectToAction("ShowProductDetail", new { id = model.ProductID });
        }

        public ActionResult EditProduct(int id)
        {

            return View(productRepository.FindById(id));
        }

        public ActionResult RemoveProduct(int id)
        {
     
            productRepository.Remove(id);
            return RedirectToAction("ShowProducts");

        }
    }
}