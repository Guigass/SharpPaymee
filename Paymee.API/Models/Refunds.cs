using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paymee.API.Models
{
    public partial class Refunds
    {
        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        [JsonProperty("requested")]
        public double Requested { get; set; }

        [JsonProperty("available")]
        public double Available { get; set; }

        [JsonProperty("transactions")]
        public Transaction[] Transactions { get; set; }
    }
}
