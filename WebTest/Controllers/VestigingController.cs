using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTest.Repos;

namespace WebTest.Controllers
{
    public class VestigingController : Controller
    {
        VestigingRepository vestigingRepository = new VestigingRepository();
        // GET: Vestiging
        public ActionResult ShowVestigingen()
        {
            return View(vestigingRepository.GetVestigingen());
        }

        public ActionResult ShowVestigingDetail(int id)
        {

            return View(vestigingRepository.FindById(id));
        }

        // POST: Vestiging/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
