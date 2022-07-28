using commercetools.Sdk.Api.Models.Channels;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.InventoryEntryQuantitySetMessagePayload))]
    public partial interface IInventoryEntryQuantitySetMessagePayload : IMessagePayload
    {
        long OldQuantityOnStock { get; set; }

        long NewQuantityOnStock { get; set; }

        long OldAvailableQuantity { get; set; }

        long NewAvailableQuantity { get; set; }

        IChannelReference SupplyChannel { get; set; }

    }
}
