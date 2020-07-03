using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paymee.API.Models
{
    public partial class Request
    {
        [JsonProperty("headers")]
        public RequestHeaders Headers { get; set; }

        [JsonProperty("payload")]
        public string Payload { get; set; }
    }
}
