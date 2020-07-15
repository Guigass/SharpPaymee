using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paymee.API.Models
{
    public partial class BalanceResponse
    {
        [JsonProperty("status")]
        public long Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("balance")]
        public double Balance { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }
    }
}
