using commercetools.Api.Models.Common;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Payments
{
    public class Transaction 
    {
        public string Id { get; set;}
        
        public DateTime Timestamp { get; set;}
        
        public TransactionType Type { get; set;}
        
        public TypedMoney Amount { get; set;}
        
        public string InteractionId { get; set;}
        
        public TransactionState State { get; set;}
    }
}
