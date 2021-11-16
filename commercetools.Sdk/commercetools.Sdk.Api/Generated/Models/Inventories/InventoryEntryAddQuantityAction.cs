namespace commercetools.Api.Models.Inventories
{
    public partial class InventoryEntryAddQuantityAction : IInventoryEntryAddQuantityAction
    {
        public string Action { get; set; }

        public long Quantity { get; set; }
        public InventoryEntryAddQuantityAction()
        {
            this.Action = "addQuantity";
        }
    }
}
