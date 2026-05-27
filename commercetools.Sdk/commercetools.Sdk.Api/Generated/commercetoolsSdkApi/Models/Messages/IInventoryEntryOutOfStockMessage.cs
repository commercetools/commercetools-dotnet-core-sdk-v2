using commercetools.Sdk.Api.Models.Channels;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.InventoryEntryOutOfStockMessage))]
    public partial interface IInventoryEntryOutOfStockMessage : IMessage
    {
        string Sku { get; set; }

        IChannelReference SupplyChannel { get; set; }

    }
}
