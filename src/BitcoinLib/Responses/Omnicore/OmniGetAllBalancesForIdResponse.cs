using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace BitcoinLib.Responses
{

    //omni_getallbalancesforid
    public class OmniGetAllBalancesForIdResponse
    {

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("balance")]
        public decimal Balance { get; set; }

        [JsonProperty("reserved")]
        public decimal Reserved { get; set; }

    }

}
