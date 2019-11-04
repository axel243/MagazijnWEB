using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebTest.Models
{
    public class VoorraadModel
    {
        public VoorraadModel(int? voorraad1, int vestigingID, int productID)
        {
            Voorraad1 = voorraad1;
            VestigingID = vestigingID;
            ProductID = productID;
        }

        public Nullable<int> Voorraad1 { get; set; }
        public int VestigingID { get; set; }
        public int ProductID { get; set; }

        public  ProductModel Product { get; set; }
        public  VestigingModel Vestiging { get; set; }
    }
}