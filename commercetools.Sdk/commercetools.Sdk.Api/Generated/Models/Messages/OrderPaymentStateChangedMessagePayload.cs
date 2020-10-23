using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    public  partial class OrderPaymentStateChangedMessagePayload : IOrderPaymentStateChangedMessagePayload
    {
        public string Type { get; set;}
        
        public string PaymentState { get; set;}
        
        [JsonIgnore]
        public PaymentState PaymentStateAsEnum => this.PaymentState.GetEnum<PaymentState>();
        
        public string OldPaymentState { get; set;}
        
        [JsonIgnore]
        public PaymentState OldPaymentStateAsEnum => this.OldPaymentState.GetEnum<PaymentState>();
        public OrderPaymentStateChangedMessagePayload()
        { 
           this.Type = "OrderPaymentStateChanged";
        }
    }
}
