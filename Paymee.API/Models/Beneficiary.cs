using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paymee.API.Models
{
    public partial class Beneficiary
    {
        [JsonProperty("document")]
        public Document Document { get; set; }

        [JsonProperty("bankDetails")]
        public BankDetails BankDetails { get; set; }
    }
}
