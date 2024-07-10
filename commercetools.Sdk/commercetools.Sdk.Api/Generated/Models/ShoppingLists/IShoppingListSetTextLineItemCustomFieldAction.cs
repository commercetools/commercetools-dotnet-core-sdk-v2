using commercetools.Sdk.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetTextLineItemCustomFieldAction))]
    public partial interface IShoppingListSetTextLineItemCustomFieldAction : IShoppingListUpdateAction
    {
        string TextLineItemId { get; set; }

        string TextLineItemKey { get; set; }

        string Name { get; set; }

        Object Value { get; set; }

    }
}
