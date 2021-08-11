using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using weatherAPI.Models;

namespace weatherAPI.Controllers
{
    public class weatherController : ApiController
    {
        Random rnd = new Random();
        List<weatherValues> weatherVal = new List<weatherValues>();

        List<weatherdays> weatherValforday = new List<weatherdays>();
        public weatherController()
        {
            string[] wind= {"С","СЗ","СВ","Ю","ЮЗ","ЮВ","З","В"};
            int counterwind = rnd.Next(wind.Length);
            string[] percip = { "sunny", "cloudy", "light rain", "heavy rain", "thunderstorm" };
            int counterpercip = rnd.Next(percip.Length);
            
            weatherVal.Add(new weatherValues{
                mintemp = rnd.Next(15, 20), 
                pressure = rnd.Next(740, 745), 
                powerwind = rnd.Next(1, 9),
                directionwind = wind[counterwind],
                precipitation= percip[counterpercip]
            });

        }
        // GET: api/weather
        public List<weatherValues> Get()
        { 
            return weatherVal;
        }

        // GET: api/weather/5
        public List<weatherdays> Get(int id)
        {
            weatherValforday.Add(new weatherdays { currentdate = DateTime.Today.AddDays(id).ToLongDateString() });
            return weatherValforday;
        }

        // POST: api/weather
        public void Post([FromBody]string value)
        {
        }

        // DELETE: api/weather/5
        public void Delete(int id)
        {
        }
    }
}
