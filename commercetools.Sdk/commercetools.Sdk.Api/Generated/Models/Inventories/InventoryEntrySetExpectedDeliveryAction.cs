using System;


namespace commercetools.Api.Models.Inventories
{
    public partial class InventoryEntrySetExpectedDeliveryAction : IInventoryEntrySetExpectedDeliveryAction
    {
        public string Action { get; set; }

        public DateTime? ExpectedDelivery { get; set; }
        public InventoryEntrySetExpectedDeliveryAction()
        {
            this.Action = "setExpectedDelivery";
        }
    }
}
