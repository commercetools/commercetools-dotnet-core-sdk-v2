using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setReturnPaymentState")]
    public partial class StagedOrderSetReturnPaymentStateAction : StagedOrderUpdateAction
    {
        public string ReturnItemId { get; set;}
        
        public string PaymentState { get; set;}
        
        [JsonIgnore]
        public ReturnPaymentState PaymentStateAsEnum => this.PaymentState.GetEnum<ReturnPaymentState>();
        public StagedOrderSetReturnPaymentStateAction()
        { 
           this.Action = "setReturnPaymentState";
        }
    }
}
