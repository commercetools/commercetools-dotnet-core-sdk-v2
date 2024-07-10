using commercetools.Sdk.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
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
