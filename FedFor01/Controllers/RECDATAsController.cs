using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
//using FedFor01.Data;
using FedFor01.Models;
using System.Threading.Tasks;
using System.Text;

namespace FedFor01.Controllers
{
    public class RECDATAsController : Controller
    {
        //private FedFor01Context db = new FedFor01Context();

        // GET: RECDATAs
        public ActionResult Index()
        {
            var t = Task.Run(() => AwaitOperatorCustom.curlRequestAsync(usersearch: null, offset: 0, usercount: 50, state: null, sort: null, activity: null));
            t.Wait();
            return View(t.Result);
        }

        // GET: RECDATAs/Details/5
        public ActionResult Details(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return HttpNotFound();
            }

            var t = Task.Run(() => AwaitOperatorFacility.curlRequestAsyncTest(facilityID: id));
            t.Wait();
            //var model = t.Result;
            //ViewBag.test = model;
            return View(t.Result);
        }


    }
}
