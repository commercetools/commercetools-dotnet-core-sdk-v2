using commercetools.Sdk.Api.Models.Channels;


namespace commercetools.Sdk.Api.Models.Messages
{
    public partial class InventoryEntryDeletedMessagePayload : IInventoryEntryDeletedMessagePayload
    {
        public string Type { get; set; }

        public string Sku { get; set; }

        public IChannelReference SupplyChannel { get; set; }
        public InventoryEntryDeletedMessagePayload()
        {
            this.Type = "InventoryEntryDeleted";
        }
    }
}
