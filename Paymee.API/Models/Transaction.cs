using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paymee.API.Models
{
    public partial class Transaction
    {
        [JsonProperty("uuid")]
        public Guid Uuid { get; set; }

        [JsonProperty("total")]
        public double Total { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("creation")]
        public DateTimeOffset Creation { get; set; }

        [JsonProperty("creditDate")]
        public DateTimeOffset CreditDate { get; set; }

        [JsonProperty("bankDetails")]
        public TransactionBankDetails BankDetails { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("creditTransferDetails")]
        public CreditTransferDetails CreditTransferDetails { get; set; }
    }
}
