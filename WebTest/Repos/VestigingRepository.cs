using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebTest.Interfaces;
using WebTest.Models;

namespace WebTest.Repos
{
    public class VestigingRepository {

        private MagazijnEntities context = new MagazijnEntities();
        public void Add(VestigingModel v)
        {
            throw new NotImplementedException();
        }

        public void Edit(ProductModel p)
        {
            throw new NotImplementedException();
        }

        public Vestiging FindById(int Id)
        {
            return context.Vestigings.Where(v => v.VestigingID == Id).FirstOrDefault();
        }

        public IEnumerable<Vestiging> GetVestigingen()
        {
            return context.Vestigings.ToList();
        }

        public void Remove(int Id)
        {
            throw new NotImplementedException();
        }
    }
}