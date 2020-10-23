using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Orders
{
    public interface IDeliveryItem 
    {
        string Id { get; set;}
        
        double Quantity { get; set;}
    }
}
