using commercetools.Sdk.Api.Models.ShoppingLists;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetTextLineItemCustomTypeAction))]
    public partial interface IShoppingListSetTextLineItemCustomTypeAction : IShoppingListUpdateAction
    {
        string TextLineItemId { get; set; }

        string TextLineItemKey { get; set; }

        ITypeResourceIdentifier Type { get; set; }

        IFieldContainer Fields { get; set; }

    }
}
