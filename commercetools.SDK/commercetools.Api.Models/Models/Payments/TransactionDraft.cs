using commercetools.Api.Models.Common;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    public class TransactionDraft 
    {
        public DateTime Timestamp { get; set;}
        
        public string Type { get; set;}
        
        public TransactionType TypeAsEnum => this.Type.GetEnum<TransactionType>();
        
        public Money Amount { get; set;}
        
        public string InteractionId { get; set;}
        
        public string State { get; set;}
        
        public TransactionState StateAsEnum => this.State.GetEnum<TransactionState>();
    }
}
