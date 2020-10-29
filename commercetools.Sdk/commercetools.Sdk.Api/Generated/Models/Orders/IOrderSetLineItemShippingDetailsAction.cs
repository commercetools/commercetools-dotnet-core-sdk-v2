using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderSetLineItemShippingDetailsAction))]
    public interface IOrderSetLineItemShippingDetailsAction : IOrderUpdateAction
    {
        string LineItemId { get; set;}
        
        IItemShippingDetailsDraft ShippingDetails { get; set;}
    }
}
