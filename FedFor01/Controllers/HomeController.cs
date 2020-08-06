using System.Web.Mvc;
using System.Threading.Tasks;
using System;
using FedFor01.Models;
using System.Collections.Generic;
using System.Text;


namespace FedFor01.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();

        }


        [HttpGet]
        public ActionResult Facility()
        {

            List<RECDATA> Lcamp = new List<RECDATA>();
            ViewBag.count = 0;
            ViewBag.lat = 0;
            ViewBag.lng = 0;

            return View(Lcamp);


            //           var t = Task.Run(() => AwaitOperatorCustom.curlRequestAsync(usersearch: null, offset: 0, usercount: 0, state: null, sort: null, activity: null));
            //t.Wait();
            //return View(t.Result);
        }

        [HttpPost]
        public ActionResult Facility(string lat, string lng, string search, string searchnumber, string stateinitial, string sort, string[] activity, string offset)
        {
            ViewBag.Message = "find a site.";

            ViewBag.offsetnumber = offset;

            switch (sort)
            {
                case "Name":
                    ViewBag.NameSelect = "selected";
                    break;

                case "ID":
                    ViewBag.IDSelect = "selected";
                    break;

                case "Date":
                    ViewBag.DateSelect = "selected";
                    break;
            }

            string activitystring = "";
            if (activity?.Length > 0)
            {
                StringBuilder builder = new StringBuilder();
                int i = 1;
                foreach (string value in activity)
                {
                    if (i == activity.Length) //Use count or length as supported by your collection
                    {
                        builder.Append(value);
                    }
                    else
                    {
                        builder.Append(value);
                        builder.Append(',');
                        i++;
                    }
                }
                activitystring = builder.ToString();

            }

            int searchnumberint = 50;
            if (string.IsNullOrEmpty(searchnumber) == false)
            {
                searchnumberint = Int32.Parse(searchnumber);
            }

            int offsetVal = 0;
            if (string.IsNullOrEmpty(offset) == false)
            {
                offsetVal = Int32.Parse(offset);
            }

            ViewBag.lat = lat;
            ViewBag.lng = lng;

            var t = Task.Run(() => AwaitOperatorCustom.curlReloadAsync(usersearch: search, offset: offsetVal, usercount: searchnumberint, state: stateinitial, sort: sort, activity: activitystring, lat: lat, lng: lng));
            t.Wait();
            ViewBag.count = t.Result.Count.ToString();
            return View(t.Result);
        }


        public ActionResult FacilitySearch(string search, string searchnumber, string stateinitial, string sort, string activity, string offset)
        {
            int searchnumberint = 50;
            if (string.IsNullOrEmpty(searchnumber) == false)
            {
                searchnumberint = Int32.Parse(searchnumber);
            }

            int offsetVal = 0;
            if (string.IsNullOrEmpty(offset) == false)
            {
                offsetVal = Int32.Parse(offset);
            }

            var t = Task.Run(() => AwaitOperatorCustom.curlRequestAsync(usersearch: search, offset: offsetVal, usercount: searchnumberint, state: stateinitial, sort: sort, activity: activity));
            t.Wait();
            return View(t.Result);
        }

        [HttpGet]
        public ActionResult FacilityMapSearch()
        {
            var t = Task.Run(() => AwaitOperatorCustom.curlRequestAsync(usersearch: null, offset: 0, usercount: 0, state: null, sort: null, activity: null));
            t.Wait();
            return View(t.Result);


            //int offset = 0;
            //void IncreaseOffset()
            //{
            //    offset = offset + 50;
            //}
        }

        [HttpPost]
        public ActionResult FacilityMapSearch(string search, string searchnumber, string stateinitial, string sort, string[] activity, string offset)
        {

            ViewBag.offsetnumber = offset;

            switch (sort)
            {
                case "Name":
                    ViewBag.NameSelect = "selected";
                    break;

                case "ID":
                    ViewBag.IDSelect = "selected";
                    break;

                case "Date":
                    ViewBag.DateSelect = "selected";
                    break;
            }

            string activitystring = "";
            if (activity?.Length > 0)
            {
                StringBuilder builder = new StringBuilder();
                int i = 1;
                foreach (string value in activity)
                {
                    if (i == activity.Length) //Use count or length as supported by your collection
                    {
                        builder.Append(value);
                    }
                    else
                    {
                        builder.Append(value);
                        builder.Append(',');
                        i++; 
                    }
                }
                activitystring = builder.ToString();

            }

            int searchnumberint = 50;
            if (string.IsNullOrEmpty(searchnumber) == false)
            {
                searchnumberint = Int32.Parse(searchnumber);
            }

            int offsetVal = 0;
            if (string.IsNullOrEmpty(offset) == false)
            {
                offsetVal = Int32.Parse(offset);
            }

            var t = Task.Run(() => AwaitOperatorCustom.curlRequestAsync(usersearch: search, offset: offsetVal, usercount: searchnumberint, state: stateinitial, sort: sort, activity: activitystring));
            t.Wait();
            return View(t.Result);

            //int offset = 0;
            //void IncreaseOffset()
            //{
            //    offset = offset + 50;
            //}
        }

    }
}
