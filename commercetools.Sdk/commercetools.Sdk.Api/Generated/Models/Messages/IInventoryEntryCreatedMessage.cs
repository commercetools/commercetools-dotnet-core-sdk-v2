using commercetools.Sdk.Api.Models.Inventories;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.InventoryEntryCreatedMessage))]
    public partial interface IInventoryEntryCreatedMessage : IMessage
    {
        IInventoryEntry InventoryEntry { get; set; }
    }
}
