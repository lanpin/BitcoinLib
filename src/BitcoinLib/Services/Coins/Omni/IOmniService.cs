using System.Collections.Generic;
using BitcoinLib.Requests;
using BitcoinLib.Responses;

namespace BitcoinLib.Services.Coins.Omni
{
    public interface IOmniService
    {
        string Omni_CreatePayLoad_SendAll(long ecosystem);
        string Omni_CreatePayLoad_SimpleSend(long propertyid, string amount);
        string Omni_CreateRawTx_Change(string rawtx, List<CreateRawTransactionChange> prevtxs, string destination, string fee, long? position = null);
        string Omni_CreateRawTx_Opreturn(string rawtx, string payload);
        string Omni_CreateRawTx_Reference(string rawtx, string destination, string amount = null);
        List<OmniGetAllBalancesForIdResponse> Omni_GetAllBalancesForId(int propertyid);
        OmniGetBalanceResponse Omni_GetBalance(string address, long propertyid);
        OmniGetTransactionResponse Omni_GetTransaction(string txid);
        List<string> Omni_ListBlockTransactions(long index);
        string Omni_Send(string fromaddress, string toaddress, long propertyid, string amount);
        string Omni_Send(string fromaddress, string toaddress, long propertyid, string amount, string redeemaddress, string referenceamount);
    }
}