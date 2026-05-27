

namespace commercetools.Sdk.Api.Models.Inventories
{

    public partial class InventoryEntrySetSafetyStockAction : IInventoryEntrySetSafetyStockAction
    {
        public string Action { get; set; }

        public int? Quantity { get; set; }
        public InventoryEntrySetSafetyStockAction()
        {
            this.Action = "setSafetyStock";
        }
    }
}
