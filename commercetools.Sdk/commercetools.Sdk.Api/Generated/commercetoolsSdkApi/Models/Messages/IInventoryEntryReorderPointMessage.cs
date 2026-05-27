using commercetools.Sdk.Api.Models.Channels;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.InventoryEntryReorderPointMessage))]
    public partial interface IInventoryEntryReorderPointMessage : IMessage
    {
        string Sku { get; set; }

        int QuantityOnStock { get; set; }

        IChannelReference SupplyChannel { get; set; }

    }
}
