using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paymee.API.Models
{
    public partial class CheckOutResponse
    {
        [JsonProperty("status")]
        public long Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("response", NullValueHandling = NullValueHandling.Ignore)]
        public Response Response { get; set; }
    }

    public partial class CheckOutPIXResponse
    {
        [JsonProperty("status")]
        public long Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("response", NullValueHandling = NullValueHandling.Ignore)]
        public ResponsePIX ResponsePIX { get; set; }
    }
}
