using commercetools.Sdk.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{

    public partial class ShoppingListUpdate : IShoppingListUpdate
    {
        public long Version { get; set; }

        public IList<IShoppingListUpdateAction> Actions { get; set; }
        public IEnumerable<IShoppingListUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
