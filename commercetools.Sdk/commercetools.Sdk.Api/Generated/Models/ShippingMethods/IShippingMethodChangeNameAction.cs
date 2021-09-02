using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShippingMethods.ShippingMethodChangeNameAction))]
    public partial interface IShippingMethodChangeNameAction : IShippingMethodUpdateAction
    {
        string Name { get; set; }
    }
}
