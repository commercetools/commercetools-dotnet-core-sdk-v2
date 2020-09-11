using commercetools.Api.Models.Common;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Payments
{
    public class TransactionDraft 
    {
        public DateTime Timestamp { get; set;}
        
        public TransactionType Type { get; set;}
        
        public Money Amount { get; set;}
        
        public string InteractionId { get; set;}
        
        public TransactionState State { get; set;}
    }
}
