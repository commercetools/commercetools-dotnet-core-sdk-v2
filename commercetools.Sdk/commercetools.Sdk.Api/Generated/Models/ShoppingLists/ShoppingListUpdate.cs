using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    public partial class ShoppingListUpdate : IShoppingListUpdate
    {
        public long Version { get; set; }

        public List<IShoppingListUpdateAction> Actions { get; set; }
    }
}
