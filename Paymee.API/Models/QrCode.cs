using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paymee.API.Models
{
    public class QrCode
    {
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("base64")]
        public string Base64 { get; set; }
        [JsonProperty("plain")]
        public string Plain { get; set; }
    }
}
