using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{

    public partial class ShoppingListUpdate : IShoppingListUpdate
    {
        public long Version { get; set; }

        public IList<IShoppingListUpdateAction> Actions { get; set; }
        public IEnumerable<IShoppingListUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
