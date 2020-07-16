using System.Web.Mvc;
using System.Threading.Tasks;
using System;


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


        public ActionResult Facility()
        {
            ViewBag.Message = "find a site.";

            //IEnumerable<FacilityModels> Facility = null;

            //RECDATA Facility = new RECDATA();

            //string json = JsonConvert.SerializeObject(Facility, Formatting.Indented);



            var t = Task.Run(() => AwaitOperator.curlRequestAsync());
            t.Wait();

            return View(t.Result);


            // return View();
        }

        public ActionResult FacilitySearch(string search, string searchnumber, string stateinitial, string sort, string activity)
        {
            int searchnumberint = 50;
            if (string.IsNullOrEmpty(searchnumber) == false)
            {
                searchnumberint = Int32.Parse(searchnumber);
            }


            var t = Task.Run(() => AwaitOperatorCustom.curlRequestAsync(usersearch: search, usercount: searchnumberint, state: stateinitial, sort: sort, activity: activity));
            t.Wait();
            return View(t.Result);
        }

        public ActionResult FacilityMapSearch(string search, string searchnumber, string stateinitial, string sort, string activity)
        {
            int searchnumberint = 50;
            if (string.IsNullOrEmpty(searchnumber) == false)
            {
                searchnumberint = Int32.Parse(searchnumber);
            }


            var t = Task.Run(() => AwaitOperatorCustom.curlRequestAsync(usersearch: search, usercount: searchnumberint, state: stateinitial, sort: sort, activity: activity));
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
