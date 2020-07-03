using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paymee.API.Models
{
    public partial class CreditTransferDetails
    {
        [JsonProperty("saleUUID")]
        public Guid SaleUuid { get; set; }

        [JsonProperty("referenceCode")]
        public string ReferenceCode { get; set; }

        [JsonProperty("total")]
        public double Total { get; set; }
    }
}
