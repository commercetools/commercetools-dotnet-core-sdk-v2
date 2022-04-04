using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetItemShippingAddressCustomFieldAction))]
    public partial interface ICartSetItemShippingAddressCustomFieldAction : ICartUpdateAction
    {
        string AddressKey { get; set; }

        string Name { get; set; }

        Object Value { get; set; }
    }
}
