using commercetools.Api.Models.Channels;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.InventoryEntryDeletedMessagePayload))]
    public partial interface IInventoryEntryDeletedMessagePayload : IMessagePayload
    {
        string Sku { get; set;}
        
        IChannelReference SupplyChannel { get; set;}
    }
}
