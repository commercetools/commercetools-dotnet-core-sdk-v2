using commercetools.Sdk.Api.Models.Channels;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class InventoryEntryQuantitySetMessagePayload : IInventoryEntryQuantitySetMessagePayload
    {
        public string Type { get; set; }

        public long OldQuantityOnStock { get; set; }

        public long NewQuantityOnStock { get; set; }

        public long OldAvailableQuantity { get; set; }

        public long NewAvailableQuantity { get; set; }

        public string Sku { get; set; }

        public IChannelReference SupplyChannel { get; set; }
        public InventoryEntryQuantitySetMessagePayload()
        {
            this.Type = "InventoryEntryQuantitySet";
        }
    }
}
