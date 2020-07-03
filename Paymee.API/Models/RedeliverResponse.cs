using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paymee.API.Models
{
    public partial class RedeliverResponse
    {
        [JsonProperty("status")]
        public long Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("errorCount")]
        public long ErrorCount { get; set; }

        [JsonProperty("errors")]
        public Error[] Errors { get; set; }
    }
}
