using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paymee.API.Models
{
    public partial class RefundNotification
    {
        [JsonProperty("saleToken")]
        public Guid SaleToken { get; set; }

        [JsonProperty("referenceCode")]
        public string ReferenceCode { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("originalAmount")]
        public double OriginalAmount { get; set; }

        [JsonProperty("amountRefunded")]
        public double AmountRefunded { get; set; }

        [JsonProperty("bankDetails", NullValueHandling = NullValueHandling.Ignore)]
        public BankDetails BankDetails { get; set; }

        [JsonProperty("receipt")]
        public Uri Receipt { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("refund")]
        public Refund Refund { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }
    }
}
