using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paymee.API.Models
{
    public partial class TransactionResponse
    {
        [JsonProperty("status")]
        public long Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

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

        [JsonProperty("shipping")]
        public long Shipping { get; set; }

        [JsonProperty("discounts")]
        public long Discounts { get; set; }

        [JsonProperty("total")]
        public double Total { get; set; }

        [JsonProperty("appliedRate")]
        public double AppliedRate { get; set; }

        [JsonProperty("referenceCode")]
        public string ReferenceCode { get; set; }

        [JsonProperty("creation")]
        public DateTime Creation { get; set; }

        [JsonProperty("maxAge")]
        public DateTime MaxAge { get; set; }

        [JsonProperty("shopper")]
        public Shopper Shopper { get; set; }

        [JsonProperty("refunds")]
        public Refunds Refunds { get; set; }
    }
}
