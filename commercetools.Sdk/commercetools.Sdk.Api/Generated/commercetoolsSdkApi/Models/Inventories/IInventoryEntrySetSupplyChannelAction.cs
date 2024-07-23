using commercetools.Sdk.Api.Models.Channels;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Inventories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Inventories.InventoryEntrySetSupplyChannelAction))]
    public partial interface IInventoryEntrySetSupplyChannelAction : IInventoryEntryUpdateAction
    {
        IChannelResourceIdentifier SupplyChannel { get; set; }

    }
}
