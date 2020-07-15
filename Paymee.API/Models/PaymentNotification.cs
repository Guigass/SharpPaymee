using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paymee.API.Models
{
    public partial class PaymentNotification
    {
        [JsonProperty("saleToken")]
        public Guid SaleToken { get; set; }

        [JsonProperty("referenceCode")]
        public long ReferenceCode { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("shopper")]
        public Shopper Shopper { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("newStatus")]
        public string NewStatus { get; set; }
    }
}
