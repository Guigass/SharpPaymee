using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paymee.API.Models
{
    public partial class CancelPayoutRequest
    {
        [JsonProperty("uuid")]
        public Guid Uuid { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}
