using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.ChangeValues
{
    public partial class TransactionChangeValue : ITransactionChangeValue
    {
        public string Id { get; set;}
        
        public string InteractionId { get; set;}
        
        public string Timestamp { get; set;}
    }
}
