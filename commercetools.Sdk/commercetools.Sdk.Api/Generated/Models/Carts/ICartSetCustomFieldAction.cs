using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetCustomFieldAction))]
    public partial interface ICartSetCustomFieldAction : ICartUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }

    }
}
