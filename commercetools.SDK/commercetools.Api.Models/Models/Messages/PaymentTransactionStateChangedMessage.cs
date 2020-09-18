using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("PaymentTransactionStateChanged")]
    public class PaymentTransactionStateChangedMessage : Message
    {
        public string TransactionId { get; set;}
        
        public string State { get; set;}
        
        public TransactionState StateAsEnum => this.State.GetEnum<TransactionState>();
    }
}
