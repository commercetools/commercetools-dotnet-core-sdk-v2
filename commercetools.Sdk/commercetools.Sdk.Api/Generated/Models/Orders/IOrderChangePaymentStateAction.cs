using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderChangePaymentStateAction))]
    public interface IOrderChangePaymentStateAction : IOrderUpdateAction
    {
        string PaymentState { get; set;}
        
        PaymentState PaymentStateAsEnum { get; }
    }
}
