using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetCustomLineItemCustomFieldAction))]
    public partial interface ICartSetCustomLineItemCustomFieldAction : ICartUpdateAction
    {
        string CustomLineItemId { get; set; }

        string Name { get; set; }

        Object Value { get; set; }

    }
}
