using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderSetCustomLineItemCustomFieldAction))]
    public interface IOrderSetCustomLineItemCustomFieldAction : IOrderUpdateAction
    {
        string CustomLineItemId { get; set;}
        
        string Name { get; set;}
        
        Object Value { get; set;}
    }
}
