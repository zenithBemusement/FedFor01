
using System;
using System.Net.Http;
using System.Threading.Tasks;

using System.Collections.Generic;
using System.Linq;

using System.Net;
using FedFor01.ModelsSingle;

namespace FedFor01.Controllers
{


    public class AwaitOperatorFacility
    {

        public static async Task<Rootobject> curlRequestAsyncTest(string facilityID)
        // public static async Task<Rootobject> curlRequestAsync()
        //   public static async Task curlRequestAsync()
        // public static async System.Threading.Tasks.Task<HttpResponseMessage> curlRequestAsync()
        {

            //Rootobject camp = new Rootobject();


            List<Rootobject> Lcamp = new List<Rootobject>();

            //List<Rootobject> llocation = new List<Rootobject>();

            Rootobject RO = new Rootobject();

            //List<String, String> LLatLon = new List<String, String>();


            string customquery = "https://ridb.recreation.gov/api/v1/facilities/" + facilityID + "?full=true";

            try
            {


                //"
                using (var httpClient = new HttpClient())
                {
                    using (var request = new HttpRequestMessage(new HttpMethod("GET"), customquery))

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

                //Lcamp = RO.Rootobject.ToList<Rootobject>();
                //Lcamp = RO.Rootobject.Where( x=> x.FacilityType == "STANDARD ELECTRIC").ToList<Rootobject>();





                //List<course> list_course = query.ToList<course>();
            }
            catch (Exception ex)

            {

                Console.WriteLine(ex.Message);
                // log.Error("getDataAsync():: Error Message:" + ex.Message + " Inner Exception:" + ex.InnerException);


            }
            return RO;

        }
    }
}