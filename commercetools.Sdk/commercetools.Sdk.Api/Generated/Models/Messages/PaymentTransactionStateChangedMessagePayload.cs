using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    public  partial class PaymentTransactionStateChangedMessagePayload : IPaymentTransactionStateChangedMessagePayload
    {
        public string Type { get; set;}
        
        public string TransactionId { get; set;}
        
        public string State { get; set;}
        
        [JsonIgnore]
        public TransactionState StateAsEnum => this.State.GetEnum<TransactionState>();
        public PaymentTransactionStateChangedMessagePayload()
        { 
           this.Type = "PaymentTransactionStateChanged";
        }
    }
}
