using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paymee.API.Models
{
    public partial class Instructions
    {
        [JsonProperty("chosen")]
        public string Chosen { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("beneficiary_branch")]
        public string BeneficiaryBranch { get; set; }

        [JsonProperty("beneficiary_account")]
        public string BeneficiaryAccount { get; set; }

        [JsonProperty("beneficiary_name")]
        public string BeneficiaryName { get; set; }

        [JsonProperty("need_identification")]
        public bool NeedIdentification { get; set; }

        [JsonProperty("identification")]
        public long Identification { get; set; }

        [JsonProperty("steps")]
        public string[] Steps { get; set; }

        [JsonProperty("redirect_urls")]
        public RedirectUrls RedirectUrls { get; set; }
    }
}
