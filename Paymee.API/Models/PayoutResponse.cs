using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paymee.API.Models
{
    public partial class PayoutResponse
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("uuid")]
        public Guid Uuid { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("situation")]
        public string Situation { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("discounts")]
        public long Discounts { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("appliedRate")]
        public double AppliedRate { get; set; }

        [JsonProperty("creation")]
        public DateTime Creation { get; set; }
    }
}
