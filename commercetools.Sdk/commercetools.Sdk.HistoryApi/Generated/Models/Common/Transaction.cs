using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    public partial class Transaction : ITransaction
    {
        public string Id { get; set;}
        
        public string Timestamp { get; set;}
        
        public ITransactionType Type { get; set;}
        
        public IMoney Amount { get; set;}
        
        public string InteractionId { get; set;}
        
        public ITransactionState State { get; set;}
    }
}
