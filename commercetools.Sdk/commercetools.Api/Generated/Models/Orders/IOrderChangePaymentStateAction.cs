using commercetools.Api.Generated.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Orders
{
    public interface IOrderChangePaymentStateAction : IOrderUpdateAction
    {
        string PaymentState { get; set;}
        
        PaymentState PaymentStateAsEnum { get; }
    }
}
