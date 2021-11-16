using commercetools.Api.Models.Channels;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.InventoryEntryDeletedMessage))]
    public partial interface IInventoryEntryDeletedMessage : IMessage
    {
        string Sku { get; set;}
        
        IChannelReference SupplyChannel { get; set;}
    }
}
