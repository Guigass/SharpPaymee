using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paymee.API.Models
{
    public partial class ResponseHeaders
    {
        [JsonProperty("Strict-Transport-Security")]
        public string StrictTransportSecurity { get; set; }

        [JsonProperty("Cache-Control")]
        public string CacheControl { get; set; }

        [JsonProperty("X-Content-Type-Options")]
        public string XContentTypeOptions { get; set; }

        [JsonProperty("Pragma")]
        public string Pragma { get; set; }

        [JsonProperty("Expires")]
        public long Expires { get; set; }

        [JsonProperty("X-XSS-Protection")]
        public string XXssProtection { get; set; }

        [JsonProperty("Content-Length")]
        public long ContentLength { get; set; }

        [JsonProperty("Date")]
        public string Date { get; set; }
    }
}
