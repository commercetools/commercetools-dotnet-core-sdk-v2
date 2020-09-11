using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Messages
{
    public class PaymentTransactionStateChangedMessagePayload : MessagePayload
    {
        public string TransactionId { get; set;}
        
        public TransactionState State { get; set;}
    }
}
