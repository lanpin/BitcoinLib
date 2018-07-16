// Copyright (c) 2014 - 2016 George Kimionis
// See the accompanying file LICENSE for the Software License Aggrement

using System.Collections.Generic;
using BitcoinLib.CoinParameters.Bitcoin;
using BitcoinLib.Requests;
using BitcoinLib.Responses;
using BitcoinLib.RPC.Specifications;

namespace BitcoinLib.Services.Coins.Omni
{
    public class OmniService : CoinService, IOmniService
    {
        public OmniService(bool useTestnet = false) : base(useTestnet)
        {
        }

        public OmniService(string daemonUrl, string rpcUsername, string rpcPassword, string walletPassword)
            : base(daemonUrl, rpcUsername, rpcPassword, walletPassword)
        {
        }

        public OmniService(string daemonUrl, string rpcUsername, string rpcPassword, string walletPassword, short rpcRequestTimeoutInSeconds)
            : base(daemonUrl, rpcUsername, rpcPassword, walletPassword, rpcRequestTimeoutInSeconds)
        {
        }

        public BitcoinConstants.Constants Constants => BitcoinConstants.Constants.Instance;


        public OmniGetTransactionResponse Omni_GetTransaction(string txid)
        {
            return _rpcConnector.MakeRequest<OmniGetTransactionResponse>(RpcMethods.omni_gettransaction, txid);
        }
        public List<string> Omni_ListBlockTransactions(long index)
        {
            return _rpcConnector.MakeRequest<List<string>>(RpcMethods.omni_listblocktransactions, index);
        }

        public string Omni_Send(string fromaddress, string toaddress, long propertyid, string amount)
        {
            return _rpcConnector.MakeRequest<string>(RpcMethods.omni_send, fromaddress, toaddress, propertyid, amount);
        }

        public string Omni_Send(string fromaddress, string toaddress, long propertyid, string amount, string redeemaddress, string referenceamount)
        {
            return _rpcConnector.MakeRequest<string>(RpcMethods.omni_send, fromaddress, toaddress, propertyid, amount, redeemaddress, referenceamount);
        }

        public OmniGetBalanceResponse Omni_GetBalance(string address, long propertyid)
        {
            return _rpcConnector.MakeRequest<OmniGetBalanceResponse>(RpcMethods.omni_getbalance, address, propertyid);
        }

        public string Omni_CreatePayLoad_SimpleSend(long propertyid, string amount)
        {
            return _rpcConnector.MakeRequest<string>(RpcMethods.omni_createpayload_simplesend, propertyid, amount);
        }

        public string Omni_CreatePayLoad_SendAll(long ecosystem)
        {
            return _rpcConnector.MakeRequest<string>(RpcMethods.omni_createpayload_sendall, ecosystem);
        }

        public string Omni_CreateRawTx_Opreturn(string rawtx, string payload)
        {
            return _rpcConnector.MakeRequest<string>(RpcMethods.omni_createrawtx_opreturn, rawtx, payload);
        }

        public string Omni_CreateRawTx_Reference(string rawtx, string destination, string amount = null)
        {
            return string.IsNullOrWhiteSpace(amount)
                ? _rpcConnector.MakeRequest<string>(RpcMethods.omni_createrawtx_reference, rawtx, destination)
                : _rpcConnector.MakeRequest<string>(RpcMethods.omni_createrawtx_reference, rawtx, destination, amount);
        }

        public string Omni_CreateRawTx_Change(string rawtx, List<CreateRawTransactionChange> prevtxs, string destination, string fee, long? position = null)
        {
            return (position.HasValue)
                ? _rpcConnector.MakeRequest<string>(RpcMethods.omni_createrawtx_change, rawtx, prevtxs, destination, fee, position)
                : _rpcConnector.MakeRequest<string>(RpcMethods.omni_createrawtx_change, rawtx, prevtxs, destination, fee);
        }

        public List<OmniGetAllBalancesForIdResponse> Omni_GetAllBalancesForId(int propertyid)
        {
            return _rpcConnector.MakeRequest<List<OmniGetAllBalancesForIdResponse>>(RpcMethods.omni_getallbalancesforid, propertyid);
        }

    }
}