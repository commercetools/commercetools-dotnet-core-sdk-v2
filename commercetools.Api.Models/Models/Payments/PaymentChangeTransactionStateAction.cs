using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Payments
{
    public class PaymentChangeTransactionStateAction : PaymentUpdateAction
    {
        public string TransactionId { get; set;}
        
        public TransactionState State { get; set;}
    }
}
