

namespace commercetools.Sdk.Api.Models.Inventories
{

    public partial class InventoryEntrySetReorderPointAction : IInventoryEntrySetReorderPointAction
    {
        public string Action { get; set; }

        public int? Quantity { get; set; }
        public InventoryEntrySetReorderPointAction()
        {
            this.Action = "setReorderPoint";
        }
    }
}
