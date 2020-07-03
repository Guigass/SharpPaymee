using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paymee.API.Models
{
    public partial class Payment
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("referenceCode")]
        public string ReferenceCode { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("beneficiary")]
        public Beneficiary Beneficiary { get; set; }

        [JsonProperty("scheduledDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ScheduledDate { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }
    }
}
