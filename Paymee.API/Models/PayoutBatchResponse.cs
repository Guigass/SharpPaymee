using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paymee.API.Models
{
    public partial class PayoutBatchResponse
    {
        [JsonProperty("status")]
        public long Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("totalElements")]
        public long TotalElements { get; set; }

        [JsonProperty("totalPages")]
        public long TotalPages { get; set; }

        [JsonProperty("resultSize")]
        public long ResultSize { get; set; }

        [JsonProperty("result")]
        public PayoutResponse[] Result { get; set; }
    }
}
