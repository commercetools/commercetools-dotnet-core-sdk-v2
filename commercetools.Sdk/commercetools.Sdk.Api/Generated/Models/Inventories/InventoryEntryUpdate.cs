using System.Collections.Generic;


namespace commercetools.Api.Models.Inventories
{
    public partial class InventoryEntryUpdate : IInventoryEntryUpdate
    {
        public long Version { get; set; }

        public List<IInventoryEntryUpdateAction> Actions { get; set; }
    }
}
