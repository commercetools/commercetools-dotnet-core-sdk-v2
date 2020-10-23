using commercetools.Api.Generated.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.ShippingMethods
{
    public interface IShippingMethodChangeIsDefaultAction : IShippingMethodUpdateAction
    {
        bool IsDefault { get; set;}
    }
}
