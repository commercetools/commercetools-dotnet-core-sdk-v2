using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    public  partial class StagedOrderChangePaymentStateAction : IStagedOrderChangePaymentStateAction
    {
        public string Action { get; set;}
        
        public string PaymentState { get; set;}
        
        [JsonIgnore]
        public PaymentState PaymentStateAsEnum => this.PaymentState.GetEnum<PaymentState>();
        public StagedOrderChangePaymentStateAction()
        { 
           this.Action = "changePaymentState";
        }
    }
}
