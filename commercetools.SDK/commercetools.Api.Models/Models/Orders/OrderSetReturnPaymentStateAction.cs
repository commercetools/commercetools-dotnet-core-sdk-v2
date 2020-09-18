using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("setReturnPaymentState")]
    public class OrderSetReturnPaymentStateAction : OrderUpdateAction
    {
        public string ReturnItemId { get; set;}
        
        public string PaymentState { get; set;}
        
        public ReturnPaymentState PaymentStateAsEnum => this.PaymentState.GetEnum<ReturnPaymentState>();
    }
}
