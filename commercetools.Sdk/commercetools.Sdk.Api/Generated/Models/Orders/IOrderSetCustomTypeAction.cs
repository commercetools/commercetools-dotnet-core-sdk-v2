using commercetools.Api.Models.Orders;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderSetCustomTypeAction))]
    public interface IOrderSetCustomTypeAction : IOrderUpdateAction
    {
        ITypeResourceIdentifier Type { get; set;}
        
        IFieldContainer Fields { get; set;}
    }
}
