using commercetools.Sdk.Api.Models.Channels;


namespace commercetools.Sdk.Api.Models.Inventories
{
    public partial class InventoryEntrySetSupplyChannelAction : IInventoryEntrySetSupplyChannelAction
    {
        public string Action { get; set; }

        public IChannelResourceIdentifier SupplyChannel { get; set; }
        public InventoryEntrySetSupplyChannelAction()
        {
            this.Action = "setSupplyChannel";
        }
    }
}
