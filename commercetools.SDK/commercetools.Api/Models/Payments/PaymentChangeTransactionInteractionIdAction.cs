using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DiscriminatorValue("changeTransactionInteractionId")]
    public partial class PaymentChangeTransactionInteractionIdAction : PaymentUpdateAction
    {
        public string TransactionId { get; set;}
        
        public string InteractionId { get; set;}
        public PaymentChangeTransactionInteractionIdAction()
        { 
           this.Action = "changeTransactionInteractionId";
        }
    }
}
