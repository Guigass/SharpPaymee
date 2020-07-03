using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paymee.API.Models
{
    public partial class ResponseWebhook
    {
        [JsonProperty("headers")]
        public ResponseHeaders Headers { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }
    }
}
