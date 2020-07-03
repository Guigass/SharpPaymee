using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paymee.API.Models
{
    public partial class RequestHeaders
    {
        [JsonProperty("Authorization")]
        public string Authorization { get; set; }

        [JsonProperty("Content-type")]
        public string ContentType { get; set; }
    }
}
