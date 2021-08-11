using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace weatherAPI.Models
{
    public class weatherValues
    {
        
        //21-32
        public int maxtemp { get; set; } = 0;

        // 15-20
        public int mintemp { get; set; } = 0;

        //745 -750
        public int pressure { get; set; } = 0;

        // 1-9
        public int powerwind { get; set; } = 0;

        //СЗ СВ ЮЗ ЮВ С Ю З В
        public string directionwind { get; set; } = "";

        //sunny, cloudy, light rain, heavy rain, thunderstorm
        public string precipitation { get; set; } = "";
    }
    public class weatherdays
    {
        //текущий день и 9 последующих
        public string currentdate { get; set; } = "";

    }
}