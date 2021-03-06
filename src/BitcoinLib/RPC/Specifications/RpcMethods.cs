﻿// Copyright (c) 2014 - 2016 George Kimionis
// See the accompanying file LICENSE for the Software License Aggrement

namespace BitcoinLib.RPC.Specifications
{
    //  Note: Do not alter the capitalization of the enum members as they are being cast as-is to the RPC server
    public enum RpcMethods
    {
        //== Blockchain ==
        getbestblockhash,
        getblock,
        getblockchaininfo,
        getblockcount,
        getblockhash,
        getblockheader,
        getchaintips,
        getdifficulty,
        getmempoolinfo,
        getrawmempool,
        gettxout,
        gettxoutproof,
        gettxoutsetinfo,
        verifychain,
        verifytxoutproof,

        //== Control ==
        getinfo,
        help,
        stop,

        //== Generating ==
        generate,
        getgenerate,
        setgenerate,

        //== Mining ==
        getblocktemplate,
        getmininginfo,
        getnetworkhashps,
        prioritisetransaction,
        submitblock,

        //== Network ==
        addnode,
        clearbanned,
        disconnectnode,
        getaddednodeinfo,
        getconnectioncount,
        getnettotals,
        getnetworkinfo,
        getpeerinfo,
        listbanned,
        ping,
        setban,

        //== Rawtransactions ==
        createrawtransaction,
        decoderawtransaction,
        decodescript,
        fundrawtransaction,
        getrawtransaction,
        sendrawtransaction,
        signrawtransaction,
        sighashtype,

        //== Util ==
        createmultisig,
        estimatefee,
        estimatepriority,
        estimatesmartfee,
        estimatesmartpriority,
        validateaddress,
        verifymessage,

        //== Wallet ==
        abandontransaction,
        addmultisigaddress,
        addwitnessaddress,
        backupwallet,
        dumpprivkey,
        dumpwallet,
        getaccount,
        getaccountaddress,
        getaddressesbyaccount,
        getbalance,
        getnewaddress,
        getrawchangeaddress,
        getreceivedbyaccount,
        getreceivedbyaddress,
        gettransaction,
        getunconfirmedbalance,
        getwalletinfo,
        importaddress,
        importprivkey,
        importpubkey,
        importwallet,
        keypoolrefill,
        listaccounts,
        listaddressgroupings,
        listlockunspent,
        listreceivedbyaccount,
        listreceivedbyaddress,
        listsinceblock,
        listtransactions,
        listunspent,
        lockunspent,
        move,
        sendfrom,
        sendmany,
        sendtoaddress,
        setaccount,
        settxfee,
        signmessage,
        walletlock,
        walletpassphrase,
        walletpassphrasechange,

        //=== Omni Layer ===
        omni_setautocommit,
        omni_getactivations,
        omni_getactivecrowdsales,
        omni_getactivedexsells,
        omni_getallbalancesforaddress,
        omni_getallbalancesforid,
        omni_getbalance,
        omni_getbalanceshash,
        omni_getcrowdsale,
        omni_getcurrentconsensushash,
        omni_getfeecache,
        omni_getfeedistribution,
        omni_getfeedistributions,
        omni_getfeeshare,
        omni_getfeetrigger,
        omni_getgrants,
        omni_getinfo,
        omni_getmetadexhash,
        omni_getorderbook,
        omni_getpayload,
        omni_getproperty,
        omni_getseedblocks,
        omni_getsto,
        omni_gettrade,
        omni_gettradehistoryforaddress,
        omni_gettradehistoryforpair,
        omni_gettransaction,
        omni_listblocktransactions,
        omni_listpendingtransactions,
        omni_listproperties,
        omni_listtransactions,
        omni_createpayload_cancelalltrades,
        omni_createpayload_canceltradesbypair,
        omni_createpayload_canceltradesbyprice,
        omni_createpayload_changeissuer,
        omni_createpayload_closecrowdsale,
        omni_senddexaccept,
        omni_createpayload_dexsell,
        omni_createpayload_disablefreezing,
        omni_createpayload_enablefreezing,
        omni_createpayload_freeze,
        omni_createpayload_grant,
        omni_createpayload_issuancecrowdsale,
        omni_createpayload_issuancefixed,
        omni_createpayload_issuancemanaged,
        omni_createpayload_revoke,
        omni_createpayload_sendall,
        omni_createpayload_simplesend,
        omni_createpayload_sto,
        omni_createpayload_trade,
        omni_createpayload_unfreeze,
        omni_createrawtx_change,
        omni_createrawtx_input,
        omni_createrawtx_multisig,
        omni_createrawtx_opreturn,
        omni_createrawtx_reference,
        omni_decodetransaction,
        omni_send,
        omni_sendall,
        omni_sendcancelalltrades,
        omni_sendcanceltradesbypair,
        omni_sendcanceltradesbyprice,
        omni_sendchangeissuer,
        omni_sendclosecrowdsale,
        omni_senddexsell,
        omni_senddisablefreezing,
        omni_sendenablefreezing,
        omni_sendfreeze,
        omni_sendgrant,
        omni_sendissuancecrowdsale,
        omni_sendissuancefixed,
        omni_sendissuancemanaged,
        omni_sendrawtx,
        omni_sendrevoke,
        omni_sendsto,
        omni_sendtrade,
        omni_sendunfreeze
    }
}