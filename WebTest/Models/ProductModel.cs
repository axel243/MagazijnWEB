using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebTest.Validators;

namespace WebTest.Models
{
    public class ProductModel
    {
        public ProductModel()
        {
        }

        public ProductModel(int productID, string name)
        {
            ProductID = productID;
            Name = name;
        }

        public int ProductID { get; set; }

        [ProductNameValidator]
        public string Name { get; set; }


    }
}