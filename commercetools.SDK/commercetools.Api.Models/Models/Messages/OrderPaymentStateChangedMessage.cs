using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("OrderPaymentStateChanged")]
    public class OrderPaymentStateChangedMessage : Message
    {
        public string PaymentState { get; set;}
        
        public PaymentState PaymentStateAsEnum => this.PaymentState.GetEnum<PaymentState>();
        
        public string OldPaymentState { get; set;}
        
        public PaymentState OldPaymentStateAsEnum => this.OldPaymentState.GetEnum<PaymentState>();
    }
}
