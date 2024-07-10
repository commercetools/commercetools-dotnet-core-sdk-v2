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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListUpdate))]
    public partial interface IShoppingListUpdate
    {
        long Version { get; set; }

        IList<IShoppingListUpdateAction> Actions { get; set; }
        IEnumerable<IShoppingListUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
