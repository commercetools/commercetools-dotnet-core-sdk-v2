using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetShippingCustomFieldAction))]
    public partial interface ICartSetShippingCustomFieldAction : ICartUpdateAction
    {
        string ShippingKey { get; set; }

        string Name { get; set; }

        Object Value { get; set; }

    }
}
