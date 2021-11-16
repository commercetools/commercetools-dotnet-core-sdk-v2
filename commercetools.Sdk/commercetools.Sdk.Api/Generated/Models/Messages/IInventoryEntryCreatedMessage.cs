using commercetools.Api.Models.Inventories;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.InventoryEntryCreatedMessage))]
    public partial interface IInventoryEntryCreatedMessage : IMessage
    {
        IInventoryEntry InventoryEntry { get; set;}
    }
}
