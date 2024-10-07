using commercetools.Sdk.Api.Models.Channels;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.InventoryEntryDeletedMessage))]
    public partial interface IInventoryEntryDeletedMessage : IMessage
    {
        string Sku { get; set; }

        IChannelReference SupplyChannel { get; set; }

    }
}
