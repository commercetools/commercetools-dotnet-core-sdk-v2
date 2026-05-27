using commercetools.Sdk.Api.Models.Channels;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class InventoryEntryReorderPointMessagePayload : IInventoryEntryReorderPointMessagePayload
    {
        public string Type { get; set; }

        public string Sku { get; set; }

        public int QuantityOnStock { get; set; }

        public IChannelReference SupplyChannel { get; set; }
        public InventoryEntryReorderPointMessagePayload()
        {
            this.Type = "InventoryEntryReorderPoint";
        }
    }
}
