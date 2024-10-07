using commercetools.Sdk.Api.Models.Inventories;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.InventoryEntryCreatedMessagePayload))]
    public partial interface IInventoryEntryCreatedMessagePayload : IMessagePayload
    {
        IInventoryEntry InventoryEntry { get; set; }

    }
}
