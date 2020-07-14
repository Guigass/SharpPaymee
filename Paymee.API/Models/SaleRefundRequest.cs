using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paymee.API.Models
{
    public partial class SaleRefundRequest
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}
