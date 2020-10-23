using commercetools.Api.Generated.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Orders
{
    public interface IOrderSetReturnPaymentStateAction : IOrderUpdateAction
    {
        string ReturnItemId { get; set;}
        
        string PaymentState { get; set;}
        
        ReturnPaymentState PaymentStateAsEnum { get; }
    }
}
