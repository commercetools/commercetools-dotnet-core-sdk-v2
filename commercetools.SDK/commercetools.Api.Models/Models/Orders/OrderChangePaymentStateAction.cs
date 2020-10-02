using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("changePaymentState")]
    public partial class OrderChangePaymentStateAction : OrderUpdateAction
    {
        public string PaymentState { get; set;}
        
        [JsonIgnore]
        public PaymentState PaymentStateAsEnum => this.PaymentState.GetEnum<PaymentState>();
        public OrderChangePaymentStateAction()
        { 
           this.Action = "changePaymentState";
        }
    }
}
