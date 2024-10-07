

namespace commercetools.Sdk.Api.Models.Inventories
{

    public partial class InventoryEntryRemoveQuantityAction : IInventoryEntryRemoveQuantityAction
    {
        public string Action { get; set; }

        public long Quantity { get; set; }
        public InventoryEntryRemoveQuantityAction()
        {
            this.Action = "removeQuantity";
        }
    }
}
