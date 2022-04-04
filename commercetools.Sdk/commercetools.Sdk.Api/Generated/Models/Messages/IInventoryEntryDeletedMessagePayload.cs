using commercetools.Sdk.Api.Models.Channels;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.InventoryEntryDeletedMessagePayload))]
    public partial interface IInventoryEntryDeletedMessagePayload : IMessagePayload
    {
        string Sku { get; set; }

        IChannelReference SupplyChannel { get; set; }
    }
}
