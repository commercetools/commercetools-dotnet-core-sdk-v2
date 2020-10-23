using commercetools.Api.Generated.Models.Orders;
using commercetools.Api.Generated.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Orders
{
    public interface IOrderSetCustomTypeAction : IOrderUpdateAction
    {
        ITypeResourceIdentifier Type { get; set;}
        
        IFieldContainer Fields { get; set;}
    }
}
