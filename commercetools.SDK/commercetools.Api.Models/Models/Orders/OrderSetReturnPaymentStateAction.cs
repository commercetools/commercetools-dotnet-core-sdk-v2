using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("setReturnPaymentState")]
    public partial class OrderSetReturnPaymentStateAction : OrderUpdateAction
    {
        public string ReturnItemId { get; set;}
        
        public string PaymentState { get; set;}
        
        [JsonIgnore]
        public ReturnPaymentState PaymentStateAsEnum => this.PaymentState.GetEnum<ReturnPaymentState>();
        public OrderSetReturnPaymentStateAction()
        { 
           this.Action = "setReturnPaymentState";
        }
    }
}
