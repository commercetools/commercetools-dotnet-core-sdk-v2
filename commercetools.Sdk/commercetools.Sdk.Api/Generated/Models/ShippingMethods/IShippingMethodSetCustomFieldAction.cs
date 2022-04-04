using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodSetCustomFieldAction))]
    public partial interface IShippingMethodSetCustomFieldAction : IShippingMethodUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }
    }
}
