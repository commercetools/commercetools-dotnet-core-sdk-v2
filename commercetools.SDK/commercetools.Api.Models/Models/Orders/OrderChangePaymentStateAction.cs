using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("changePaymentState")]
    public class OrderChangePaymentStateAction : OrderUpdateAction
    {
        public string PaymentState { get; set;}
        
        public PaymentState PaymentStateAsEnum => this.PaymentState.GetEnum<PaymentState>();
    }
}
