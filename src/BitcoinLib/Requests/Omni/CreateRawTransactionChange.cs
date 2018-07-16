using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace BitcoinLib.Requests
{
    public class CreateRawTransactionChange
    {

        [JsonProperty(PropertyName = "txid", Order = 0)]
        public string TxId { get; set; }

        [JsonProperty(PropertyName = "vout", Order = 1)]
        public int Vout { get; set; }

        [JsonProperty(PropertyName = "scriptPubKey", Order = 2)]
        public string ScriptPubKey { get; set; }

        [JsonProperty(PropertyName = "value", Order = 3)]
        public decimal Value { get; set; }


    }

}
