using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;


namespace BitcoinLib.Responses
{
    public class OmniGetTransactionResponse
    {
        [JsonProperty("txid")]
        public string TxId { get; set; }

        [JsonProperty("fee")]
        public decimal Fee { get; set; }

        [JsonProperty("sendingaddress")]
        public string SendingAddress { get; set; }

        [JsonProperty("referenceaddress")]
        public string ReferenceAddres { get; set; }

        [JsonProperty("ismine")]
        public bool IsMine { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("type_int")]
        public int TypeInt { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("propertyid")]
        public ulong PropertyId { get; set; }

        [JsonProperty("divisible")]
        public bool Divisible { get; set; }

        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        [JsonProperty("valid")]
        public bool Valid { get; set; }

        [JsonProperty("blockhash")]
        public string BlockHash { get; set; }

        [JsonProperty("blocktime")]
        public int BlockTime { get; set; }

        [JsonProperty("positioninblock")]
        public int PositionInBlock { get; set; }

        [JsonProperty("block")]
        public int Block { get; set; }

        [JsonProperty("confirmations")]
        public int Confirmations { get; set; }

    }

}
