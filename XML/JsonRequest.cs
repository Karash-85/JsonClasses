using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Json
{
    public class JsonRequest
    {
        public string type { get; set; } //"City",
        public string query { get; set; } // "Astana, Kazakhstan",
        public string language { get; set; } // "en",
        public string unit { get; set; } // "m"
    }
}
