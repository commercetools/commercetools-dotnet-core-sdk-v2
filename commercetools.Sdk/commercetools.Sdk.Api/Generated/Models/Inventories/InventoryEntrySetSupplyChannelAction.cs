using commercetools.Api.Models.Channels;


namespace commercetools.Api.Models.Inventories
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
