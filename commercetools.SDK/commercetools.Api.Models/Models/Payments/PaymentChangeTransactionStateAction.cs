using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DiscriminatorValue("changeTransactionState")]
    public partial class PaymentChangeTransactionStateAction : PaymentUpdateAction
    {
        public string TransactionId { get; set;}
        
        public string State { get; set;}
        
        [JsonIgnore]
        public TransactionState StateAsEnum => this.State.GetEnum<TransactionState>();
        public PaymentChangeTransactionStateAction()
        { 
           this.Action = "changeTransactionState";
        }
    }
}
