using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShoppingLists.ShoppingListUpdate))]
    public partial interface IShoppingListUpdate
    {
        long Version { get; set; }

        List<IShoppingListUpdateAction> Actions { get; set; }
    }
}
