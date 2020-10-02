using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("changePaymentState")]
    public partial class StagedOrderChangePaymentStateAction : StagedOrderUpdateAction
    {
        public string PaymentState { get; set;}
        
        [JsonIgnore]
        public PaymentState PaymentStateAsEnum => this.PaymentState.GetEnum<PaymentState>();
        public StagedOrderChangePaymentStateAction()
        { 
           this.Action = "changePaymentState";
        }
    }
}
