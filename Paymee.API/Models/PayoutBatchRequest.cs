using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paymee.API.Models
{
    public partial class PayoutBatchRequest
    {
        [JsonProperty("payments")]
        public Payment[] Payments { get; set; }
    }
}
