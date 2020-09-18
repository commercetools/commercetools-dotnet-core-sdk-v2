using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setReturnPaymentState")]
    public class StagedOrderSetReturnPaymentStateAction : StagedOrderUpdateAction
    {
        public string ReturnItemId { get; set;}
        
        public string PaymentState { get; set;}
        
        public ReturnPaymentState PaymentStateAsEnum => this.PaymentState.GetEnum<ReturnPaymentState>();
    }
}
