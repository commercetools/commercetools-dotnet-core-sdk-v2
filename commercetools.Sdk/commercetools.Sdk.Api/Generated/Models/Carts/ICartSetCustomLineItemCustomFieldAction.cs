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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetCustomLineItemCustomFieldAction))]
    public partial interface ICartSetCustomLineItemCustomFieldAction : ICartUpdateAction
    {
        string CustomLineItemId { get; set; }

        string CustomLineItemKey { get; set; }

        string Name { get; set; }

        Object Value { get; set; }

    }
}
