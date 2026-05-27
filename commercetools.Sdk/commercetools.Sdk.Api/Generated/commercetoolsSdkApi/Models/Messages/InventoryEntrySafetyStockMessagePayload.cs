using commercetools.Sdk.Api.Models.Channels;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class InventoryEntrySafetyStockMessagePayload : IInventoryEntrySafetyStockMessagePayload
    {
        public string Type { get; set; }

        public string Sku { get; set; }

        public int QuantityOnStock { get; set; }

        public IChannelReference SupplyChannel { get; set; }
        public InventoryEntrySafetyStockMessagePayload()
        {
            this.Type = "InventoryEntrySafetyStock";
        }
    }
}
