using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paymee.API.Models
{
    public partial class Notification
    {
        [JsonProperty("endpoint")]
        public Uri Endpoint { get; set; }

        [JsonProperty("eventType")]
        public string EventType { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("responseCode")]
        public long ResponseCode { get; set; }

        [JsonProperty("request")]
        public Request Request { get; set; }

        [JsonProperty("response")]
        public ResponseWebhook Response { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }
    }
}
