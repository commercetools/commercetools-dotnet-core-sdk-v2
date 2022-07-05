using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{

    public partial class ShoppingListUpdate : IShoppingListUpdate
    {
        public long Version { get; set; }

        public List<IShoppingListUpdateAction> Actions { get; set; }
    }
}
