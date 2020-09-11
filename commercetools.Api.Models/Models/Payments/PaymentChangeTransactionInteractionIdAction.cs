using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Payments
{
    public class PaymentChangeTransactionInteractionIdAction : PaymentUpdateAction
    {
        public string TransactionId { get; set;}
        
        public string InteractionId { get; set;}
    }
}
