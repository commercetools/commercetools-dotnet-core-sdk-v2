using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Inventories
{

    public partial class InventoryEntryUpdate : IInventoryEntryUpdate
    {
        public long Version { get; set; }

        public IList<IInventoryEntryUpdateAction> Actions { get; set; }

        public IEnumerable<IInventoryEntryUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }
    }
}
