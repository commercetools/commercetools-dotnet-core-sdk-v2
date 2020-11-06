using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.DeliveryItem))]
    public partial interface IDeliveryItem 
    {
        string Id { get; set;}
        
        double Quantity { get; set;}
    }
}
