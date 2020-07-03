using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paymee.API.Models
{
    public partial class TransactionBankDetails
    {
        [JsonProperty("bank")]
        public string Bank { get; set; }

        [JsonProperty("branch")]
        public string Branch { get; set; }

        [JsonProperty("account")]
        public string Account { get; set; }
    }
}
