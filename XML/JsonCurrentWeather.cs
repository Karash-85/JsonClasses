using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Json
{
    class JsonCurrentWeather
    {
        public DateTime observation_time { get; set; } // "03:04 PM",
        public int temperature { get; set; } // -6,
        public double weather_code { get; set; } // 116,
        public int[] getArray { get; }
        { // weather_icons
            return weather_icons;
        } // "https:\/\/assets.weatherstack.com\/images\/wsymbols01_png_64\/wsymbol_0004_black_low_cloud.png"
        public int[] setArray { set; } 
        { //weather_descriptions
            return Array;
        }  // "Partly cloudy"
        public double wind_speed { get; set; } // 19,
        public double wind_degree { get; set; } // 190,   
        public string wind_dir { get; set; } // "S",
        public double pressure { get; set; } // 1018,
        public double precip { get; set; } // 0,    
        public double humidity { get; set; } // 93,    
        public double cloudcover { get; set; } // 50,    
        public double feelslike { get; set; } // -12,   
        public int uv_index { get; set; } // 1,    
        public double visibility { get; set; } // 10,    
        public string is_day { get; set; } // "no"
    }
}
