using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderSetReturnPaymentStateAction : IStagedOrderSetReturnPaymentStateAction
    {
        public string Action { get; set;}
        
        public string ReturnItemId { get; set;}
        
        public IReturnPaymentState PaymentState { get; set;}
        public StagedOrderSetReturnPaymentStateAction()
        { 
           this.Action = "setReturnPaymentState";
        }
    }
}
