using commercetools.Sdk.Api.Models.Inventories;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class InventoryEntryCreatedMessagePayload : IInventoryEntryCreatedMessagePayload
    {
        public string Type { get; set; }

        public IInventoryEntry InventoryEntry { get; set; }
        public InventoryEntryCreatedMessagePayload()
        {
            this.Type = "InventoryEntryCreated";
        }
    }
}
