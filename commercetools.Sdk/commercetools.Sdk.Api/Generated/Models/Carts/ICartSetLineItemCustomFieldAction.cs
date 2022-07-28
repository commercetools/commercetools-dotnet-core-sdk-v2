using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetLineItemCustomFieldAction))]
    public partial interface ICartSetLineItemCustomFieldAction : ICartUpdateAction
    {
        string LineItemId { get; set; }

        string Name { get; set; }

        Object Value { get; set; }

    }
}
