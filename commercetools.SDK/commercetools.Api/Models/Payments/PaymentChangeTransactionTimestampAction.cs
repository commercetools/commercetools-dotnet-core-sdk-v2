using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DiscriminatorValue("changeTransactionTimestamp")]
    public partial class PaymentChangeTransactionTimestampAction : PaymentUpdateAction
    {
        public string TransactionId { get; set;}
        
        public DateTime Timestamp { get; set;}
        public PaymentChangeTransactionTimestampAction()
        { 
           this.Action = "changeTransactionTimestamp";
        }
    }
}
