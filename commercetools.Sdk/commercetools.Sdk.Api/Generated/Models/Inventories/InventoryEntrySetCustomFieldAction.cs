using System;


namespace commercetools.Sdk.Api.Models.Inventories
{
    public partial class InventoryEntrySetCustomFieldAction : IInventoryEntrySetCustomFieldAction
    {
        public string Action { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public InventoryEntrySetCustomFieldAction()
        {
            this.Action = "setCustomField";
        }
    }
}
