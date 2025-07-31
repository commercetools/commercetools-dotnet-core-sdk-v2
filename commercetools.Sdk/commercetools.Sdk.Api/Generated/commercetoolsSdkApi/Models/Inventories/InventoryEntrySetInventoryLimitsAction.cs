

namespace commercetools.Sdk.Api.Models.Inventories
{

    public partial class InventoryEntrySetInventoryLimitsAction : IInventoryEntrySetInventoryLimitsAction
    {
        public string Action { get; set; }

        public long? MinCartQuantity { get; set; }

        public long? MaxCartQuantity { get; set; }
        public InventoryEntrySetInventoryLimitsAction()
        {
            this.Action = "setInventoryLimits";
        }
    }
}
