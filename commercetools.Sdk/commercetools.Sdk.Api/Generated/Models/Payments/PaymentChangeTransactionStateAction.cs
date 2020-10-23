using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    public  partial class PaymentChangeTransactionStateAction : IPaymentChangeTransactionStateAction
    {
        public string Action { get; set;}
        
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
