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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListChangeTextLineItemsOrderAction))]
    public partial interface IShoppingListChangeTextLineItemsOrderAction : IShoppingListUpdateAction
    {
        IList<string> TextLineItemOrder { get; set; }
        IEnumerable<string> TextLineItemOrderEnumerable { set => TextLineItemOrder = value.ToList(); }


    }
}
