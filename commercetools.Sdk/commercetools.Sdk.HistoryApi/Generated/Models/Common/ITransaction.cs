using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Common.Transaction))]
    public partial interface ITransaction 
    {
        string Id { get; set;}
        
        string Timestamp { get; set;}
        
        ITransactionType Type { get; set;}
        
        IMoney Amount { get; set;}
        
        string InteractionId { get; set;}
        
        ITransactionState State { get; set;}
    }
}
