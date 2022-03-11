using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Types;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Inventories
{
    [DeserializeAs(typeof(commercetools.Api.Models.Inventories.InventoryEntryDraft))]
    public partial interface IInventoryEntryDraft
    {
        string Sku { get; set; }

        string Key { get; set; }

        IChannelResourceIdentifier SupplyChannel { get; set; }

        long QuantityOnStock { get; set; }

        long? RestockableInDays { get; set; }

        DateTime? ExpectedDelivery { get; set; }

        ICustomFieldsDraft Custom { get; set; }
    }
}
