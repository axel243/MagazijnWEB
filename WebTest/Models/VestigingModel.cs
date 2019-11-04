using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebTest.Models
{
    public class VestigingModel
    {
        public VestigingModel(int vestigingID, string locatie)
        {
            VestigingID = vestigingID;
            Locatie = locatie;
        }

        public int VestigingID { get; set; }
        public string Locatie { get; set; }
    }
}