using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paymee.API.Models
{
    public partial class Shopper
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("document")]
        public Document Document { get; set; }

        [JsonProperty("phone")]
        public Document Phone { get; set; }

        [JsonProperty("bankDetails")]
        public BankDetails BankDetails { get; set; }
    }
}
