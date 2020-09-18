using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("changePaymentState")]
    public class StagedOrderChangePaymentStateAction : StagedOrderUpdateAction
    {
        public string PaymentState { get; set;}
        
        public PaymentState PaymentStateAsEnum => this.PaymentState.GetEnum<PaymentState>();
    }
}
