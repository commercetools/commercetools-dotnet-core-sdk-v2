using commercetools.Sdk.Api.Models.Channels;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.InventoryEntryQuantitySetMessagePayload))]
    public partial interface IInventoryEntryQuantitySetMessagePayload : IMessagePayload
    {
        long OldQuantityOnStock { get; set; }

        long NewQuantityOnStock { get; set; }

        long OldAvailableQuantity { get; set; }

        long NewAvailableQuantity { get; set; }

        string Sku { get; set; }

        IChannelReference SupplyChannel { get; set; }

    }
}
