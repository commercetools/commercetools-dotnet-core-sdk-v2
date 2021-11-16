using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Types;
using System;


namespace commercetools.Api.Models.Inventories
{
    public partial class InventoryEntryDraft : IInventoryEntryDraft
    {
        public string Sku { get; set; }

        public IChannelResourceIdentifier SupplyChannel { get; set; }

        public long QuantityOnStock { get; set; }

        public long? RestockableInDays { get; set; }

        public DateTime? ExpectedDelivery { get; set; }

        public ICustomFieldsDraft Custom { get; set; }
    }
}
