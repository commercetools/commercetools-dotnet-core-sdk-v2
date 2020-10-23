using commercetools.Api.Generated.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Orders
{
    public interface IOrderSetCustomFieldAction : IOrderUpdateAction
    {
        string Name { get; set;}
        
        Object Value { get; set;}
    }
}
