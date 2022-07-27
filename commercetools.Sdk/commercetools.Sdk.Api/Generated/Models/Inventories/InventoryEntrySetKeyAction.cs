namespace commercetools.Sdk.Api.Models.Inventories
{

    public partial class InventoryEntrySetKeyAction : IInventoryEntrySetKeyAction
    {
        public string Action { get; set; }

        public string Key { get; set; }
        public InventoryEntrySetKeyAction()
        {
            this.Action = "setKey";
        }
    }
}
