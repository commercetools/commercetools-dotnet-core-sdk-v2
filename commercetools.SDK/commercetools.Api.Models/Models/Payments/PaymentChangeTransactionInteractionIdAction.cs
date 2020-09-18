using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DiscriminatorValue("changeTransactionInteractionId")]
    public class PaymentChangeTransactionInteractionIdAction : PaymentUpdateAction
    {
        public string TransactionId { get; set;}
        
        public string InteractionId { get; set;}
    }
}
