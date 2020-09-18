using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DiscriminatorValue("changeTransactionTimestamp")]
    public class PaymentChangeTransactionTimestampAction : PaymentUpdateAction
    {
        public string TransactionId { get; set;}
        
        public DateTime Timestamp { get; set;}
    }
}
