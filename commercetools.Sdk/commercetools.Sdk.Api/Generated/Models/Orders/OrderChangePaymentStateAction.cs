using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    public  partial class OrderChangePaymentStateAction : IOrderChangePaymentStateAction
    {
        public string Action { get; set;}
        
        public string PaymentState { get; set;}
        
        [JsonIgnore]
        public PaymentState PaymentStateAsEnum => this.PaymentState.GetEnum<PaymentState>();
        public OrderChangePaymentStateAction()
        { 
           this.Action = "changePaymentState";
        }
    }
}
