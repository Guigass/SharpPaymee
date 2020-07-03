using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paymee.API.Models
{
    public partial class ReversalNotification
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("uuid")]
        public Guid Uuid { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("originalAmount")]
        public long OriginalAmount { get; set; }

        [JsonProperty("reversedAmount")]
        public long ReversedAmount { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("bankDetails")]
        public BankDetails BankDetails { get; set; }

        [JsonProperty("creation")]
        public DateTimeOffset Creation { get; set; }

        [JsonProperty("receipt")]
        public object Receipt { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}
