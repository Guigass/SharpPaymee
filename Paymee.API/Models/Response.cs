using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paymee.API.Models
{
    public partial class Response
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("referenceCode")]
        public string ReferenceCode { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("uuid")]
        public Guid Uuid { get; set; }

        [JsonProperty("shopper")]
        public Shopper Shopper { get; set; }

        [JsonProperty("gatewayURL")]
        public Uri GatewayUrl { get; set; }

        [JsonProperty("instructions")]
        public Instructions Instructions { get; set; }
    }
}
