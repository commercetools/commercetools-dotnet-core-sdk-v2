using commercetools.Sdk.Api.Models.Channels;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class InventoryEntryOutOfStockMessagePayload : IInventoryEntryOutOfStockMessagePayload
    {
        public string Type { get; set; }

        public string Sku { get; set; }

        public IChannelReference SupplyChannel { get; set; }
        public InventoryEntryOutOfStockMessagePayload()
        {
            this.Type = "InventoryEntryOutOfStock";
        }
    }
}
