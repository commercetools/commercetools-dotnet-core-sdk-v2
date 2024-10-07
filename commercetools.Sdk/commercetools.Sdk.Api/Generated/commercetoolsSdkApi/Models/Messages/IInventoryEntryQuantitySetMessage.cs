using commercetools.Sdk.Api.Models.Channels;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.InventoryEntryQuantitySetMessage))]
    public partial interface IInventoryEntryQuantitySetMessage : IMessage
    {
        long OldQuantityOnStock { get; set; }

        long NewQuantityOnStock { get; set; }

        long OldAvailableQuantity { get; set; }

        long NewAvailableQuantity { get; set; }

        IChannelReference SupplyChannel { get; set; }

    }
}
