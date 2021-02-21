using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Json
{
    class Program
    {
        static void Main(string[] args)
        {
            var objRequest = JsonConvert.DeserializeObject<JsonRequest>(File.ReadAllText("json.json"));
            var objLocation = JsonConvert.DeserializeObject<JsonLocationCountry>(File.ReadAllText("json.json"));
            var objCurrent = JsonConvert.DeserializeObject<JsonCurrentWeather>(File.ReadAllText("json.json"));
        }
    }
}
