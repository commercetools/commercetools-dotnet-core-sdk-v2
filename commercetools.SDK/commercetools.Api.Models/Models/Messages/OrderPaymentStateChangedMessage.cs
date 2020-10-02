using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("OrderPaymentStateChanged")]
    public partial class OrderPaymentStateChangedMessage : Message
    {
        public string PaymentState { get; set;}
        
        [JsonIgnore]
        public PaymentState PaymentStateAsEnum => this.PaymentState.GetEnum<PaymentState>();
        
        public string OldPaymentState { get; set;}
        
        [JsonIgnore]
        public PaymentState OldPaymentStateAsEnum => this.OldPaymentState.GetEnum<PaymentState>();
        public OrderPaymentStateChangedMessage()
        { 
           this.Type = "OrderPaymentStateChanged";
        }
    }
}
