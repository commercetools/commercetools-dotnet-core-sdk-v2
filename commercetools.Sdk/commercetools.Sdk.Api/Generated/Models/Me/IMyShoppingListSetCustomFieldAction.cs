using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyShoppingListSetCustomFieldAction))]
    public partial interface IMyShoppingListSetCustomFieldAction : IMyShoppingListUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }

    }
}
