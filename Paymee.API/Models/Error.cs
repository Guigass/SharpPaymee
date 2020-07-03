using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paymee.API.Models
{
    public partial class Error
    {
        [JsonProperty("field")]
        public string Field { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
