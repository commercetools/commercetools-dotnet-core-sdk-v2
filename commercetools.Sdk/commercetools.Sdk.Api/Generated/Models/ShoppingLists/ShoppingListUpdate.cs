using System.Collections.Generic;


namespace commercetools.Api.Models.ShoppingLists
{
    public partial class ShoppingListUpdate : IShoppingListUpdate
    {
        public long Version { get; set;}
        
        public List<IShoppingListUpdateAction> Actions { get; set;}
    }
}
