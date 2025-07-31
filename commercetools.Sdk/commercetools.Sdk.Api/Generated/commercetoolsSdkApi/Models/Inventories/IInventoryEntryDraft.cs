using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Types;
using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Inventories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Inventories.InventoryEntryDraft))]
    public partial interface IInventoryEntryDraft
    {
        string Sku { get; set; }

        string Key { get; set; }

        IChannelResourceIdentifier SupplyChannel { get; set; }

        long QuantityOnStock { get; set; }

        int? MinCartQuantity { get; set; }

        int? MaxCartQuantity { get; set; }

        long? RestockableInDays { get; set; }

        DateTime? ExpectedDelivery { get; set; }

        ICustomFieldsDraft Custom { get; set; }

    }
}
