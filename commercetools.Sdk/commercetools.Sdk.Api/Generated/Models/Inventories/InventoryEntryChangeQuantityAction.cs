namespace commercetools.Sdk.Api.Models.Inventories
{

    public partial class InventoryEntryChangeQuantityAction : IInventoryEntryChangeQuantityAction
    {
        public string Action { get; set; }

        public long Quantity { get; set; }
        public InventoryEntryChangeQuantityAction()
        {
            this.Action = "changeQuantity";
        }
    }
}
