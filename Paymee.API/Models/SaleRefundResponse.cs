using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paymee.API.Models
{
    public partial class SaleRefundResponse
    {
        [JsonProperty("status")]
        public long Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("uuid")]
        public Guid Uuid { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("originalAmount")]
        public long OriginalAmount { get; set; }

        [JsonProperty("discounts")]
        public long Discounts { get; set; }

        [JsonProperty("totalToRefund")]
        public long TotalToRefund { get; set; }

        [JsonProperty("shopper")]
        public Shopper Shopper { get; set; }

        [JsonProperty("currentBalance")]
        public double CurrentBalance { get; set; }
    }
}
