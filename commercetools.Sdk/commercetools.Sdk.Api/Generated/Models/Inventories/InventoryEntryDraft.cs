using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


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
