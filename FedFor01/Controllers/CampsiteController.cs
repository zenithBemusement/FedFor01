using System.Web.Mvc;
using System.Threading.Tasks;
using System;
using FedFor01.CampsiteModel;
using System.Collections.Generic;
using System.Text;

namespace FedFor01.Controllers
{
    public class CampsiteController : Controller
    {
        // GET: Campsite
        public ActionResult Index(string id)
        {
            var t = Task.Run(() => AwaitOperatorCampsite.curlRequestAsync(facilityID: id));
            t.Wait();
            return View(t.Result);
        }

        // GET: Campsite/Details/5
        public ActionResult Details(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return HttpNotFound();
            }

            var t = Task.Run(() => AwaitOperatorCampsite.curlRequestAsyncSingleCamp(facilityID: id));
            t.Wait();
            //var model = t.Result;
            //ViewBag.test = model;
            return View(t.Result);
        }

        // GET: Campsite/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Campsite/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Campsite/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Campsite/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Campsite/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Campsite/Delete/5
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
