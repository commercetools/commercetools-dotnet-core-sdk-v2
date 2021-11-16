using commercetools.Api.Models.Channels;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Inventories
{
    [DeserializeAs(typeof(commercetools.Api.Models.Inventories.InventoryEntrySetSupplyChannelAction))]
    public partial interface IInventoryEntrySetSupplyChannelAction : IInventoryEntryUpdateAction
    {
        IChannelResourceIdentifier SupplyChannel { get; set; }
    }
}
