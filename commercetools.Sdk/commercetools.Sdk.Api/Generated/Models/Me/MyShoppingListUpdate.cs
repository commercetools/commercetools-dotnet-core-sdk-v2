using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyShoppingListUpdate : IMyShoppingListUpdate
    {
        public long Version { get; set; }

        public IList<IMyShoppingListUpdateAction> Actions { get; set; }
        public IEnumerable<IMyShoppingListUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
