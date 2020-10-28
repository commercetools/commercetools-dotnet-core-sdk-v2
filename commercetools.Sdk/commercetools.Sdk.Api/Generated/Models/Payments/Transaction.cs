using commercetools.Api.Models.Common;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    public partial class Transaction : ITransaction
    {
        public string Id { get; set;}
        
        public DateTime Timestamp { get; set;}
        
        public string Type { get; set;}
        
        [JsonIgnore]
        public TransactionType TypeAsEnum => this.Type.GetEnum<TransactionType>();
        
        public ITypedMoney Amount { get; set;}
        
        public string InteractionId { get; set;}
        
        public string State { get; set;}
        
        [JsonIgnore]
        public TransactionState StateAsEnum => this.State.GetEnum<TransactionState>();
    }
}
