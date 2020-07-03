using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paymee.API.Models
{
    public partial class RedirectUrls
    {
        [JsonProperty("desktop")]
        public Uri Desktop { get; set; }

        [JsonProperty("ios")]
        public Uri Ios { get; set; }

        [JsonProperty("android")]
        public Uri Android { get; set; }

        [JsonProperty("windows_phone")]
        public Uri WindowsPhone { get; set; }
    }
}
