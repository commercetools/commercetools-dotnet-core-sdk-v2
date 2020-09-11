using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Payments
{
    public class PaymentChangeTransactionTimestampAction : PaymentUpdateAction
    {
        public string TransactionId { get; set;}
        
        public DateTime Timestamp { get; set;}
    }
}
