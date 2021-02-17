using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderSetDeliveryAddressCustomTypeAction))]
    public partial interface IOrderSetDeliveryAddressCustomTypeAction : IOrderUpdateAction
    {
        string DeliveryId { get; set;}
        
        string Name { get; set;}
        
        Object Value { get; set;}
    }
}
