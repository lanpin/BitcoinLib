using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace BitcoinLib.Responses
{
    public class OmniGetBalanceResponse
    {

        [JsonProperty("balance")]
        public decimal Balance { get; set; }

        [JsonProperty("reserved")]
        public decimal Reserved { get; set; }

    }
}
