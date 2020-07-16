
using System;
using System.Net.Http;
using System.Threading.Tasks;

using System.Collections.Generic;
using System.Linq;

using System.Net;
using FedFor01.Models;

namespace FedFor01.Controllers
{


    public class AwaitOperatorCustom    
    {


        public static async Task<List<RECDATA>> curlRequestAsync(string usersearch, int usercount, string state, string sort, string activity)
        // public static async Task<RECDATA> curlRequestAsync()
        //   public static async Task curlRequestAsync()
        // public static async System.Threading.Tasks.Task<HttpResponseMessage> curlRequestAsync()
        {


            RECDATA camp = new RECDATA();
            List<RECDATA> Lcamp = new List<RECDATA>();

            List<RECDATA> llocation = new List<RECDATA>();

            Rootobject RO = new Rootobject();

            //List<String, String> LLatLon = new List<String, String>();


            string customquery = "https://ridb.recreation.gov/api/v1/facilities?query=" + usersearch + "limit=" + usercount + "&state=" + state + "&activity=" + activity + "&sort=" + sort;
            //make "campsites" variable
            string failsafe = "query=";

            if (string.IsNullOrEmpty(usersearch))
            {
                int i = customquery.IndexOf(failsafe);
                if (i >= 0)
                {
                    customquery = customquery.Remove(i, failsafe.Length);
                }
            }


            try
            {


                //"
                using (var httpClient = new HttpClient())
                {
                    using (var request = new HttpRequestMessage(new HttpMethod("GET"), customquery))

                    //     using (var request = new HttpRequestMessage(new HttpMethod("GET"), "https://ridb.recreation.gov/api/v1/Facilitys?limit=50&offset=0"))
                    {
                        request.Headers.TryAddWithoutValidation("accept", "application/json");
                        request.Headers.TryAddWithoutValidation("apikey", "2c24d35f-3ef1-42fa-a0e3-b9b128ed0350");

                        ServicePointManager.Expect100Continue = true;
                        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                               | SecurityProtocolType.Tls11
                               | SecurityProtocolType.Tls12
                               | SecurityProtocolType.Ssl3;

                        await httpClient.SendAsync(request)
                                .ContinueWith(responseTask =>
                                {
                                    var response = responseTask.Result;
                                    var jsonTask = response.Content.ReadAsAsync<Rootobject>();

                                    jsonTask.Wait();
                                    RO = jsonTask.Result;

                                });




                    }
                }

                //Lcamp = RO.RECDATA.ToList<RECDATA>();
                //Lcamp = RO.RECDATA.Where( x=> x.FacilityType == "STANDARD ELECTRIC").ToList<RECDATA>();

                Lcamp = RO.RECDATA
                    //.Where(x => x.FacilityType == "STANDARD ELECTRIC")
                    //.Where(x => x.FacilityLatitude > 0 )
                    .ToList<RECDATA>();




                //List<course> list_course = query.ToList<course>();
            }
            catch (Exception ex)

            {

                Console.WriteLine(ex.Message);
                // log.Error("getDataAsync():: Error Message:" + ex.Message + " Inner Exception:" + ex.InnerException);


            }
            return Lcamp;

        }
    }
}