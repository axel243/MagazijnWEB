using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

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
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        public virtual ProductModel Products1 { get; set; }
        public virtual ProductModel Product1 { get; set; }


    }
}