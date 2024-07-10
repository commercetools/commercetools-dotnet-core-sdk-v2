using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetShippingAddressCustomFieldAction))]
    public partial interface ICartSetShippingAddressCustomFieldAction : ICartUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }

    }
}
