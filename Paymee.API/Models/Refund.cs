using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paymee.API.Models
{
    public partial class Refund
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("uuid")]
        public Guid Uuid { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("creation")]
        public DateTimeOffset Creation { get; set; }

        [JsonProperty("creditDate")]
        public DateTimeOffset CreditDate { get; set; }
    }
}
