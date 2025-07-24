using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.RecurringOrders;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class LineItemDraft : ILineItemDraft
    {
        public string Key { get; set; }

        public string ProductId { get; set; }

        public long? VariantId { get; set; }

        public string Sku { get; set; }

        public long? Quantity { get; set; }

        public DateTime? AddedAt { get; set; }

        public IChannelResourceIdentifier DistributionChannel { get; set; }

        public IChannelResourceIdentifier SupplyChannel { get; set; }

        public IMoney ExternalPrice { get; set; }

        public IExternalLineItemTotalPrice ExternalTotalPrice { get; set; }

        public IExternalTaxRateDraft ExternalTaxRate { get; set; }

        public IList<IMethodExternalTaxRateDraft> PerMethodExternalTaxRate { get; set; }

        public IEnumerable<IMethodExternalTaxRateDraft> PerMethodExternalTaxRateEnumerable { set => PerMethodExternalTaxRate = value.ToList(); }

        public IInventoryMode InventoryMode { get; set; }

        public IItemShippingDetailsDraft ShippingDetails { get; set; }

        public ICustomFieldsDraft Custom { get; set; }

        public ILineItemRecurrenceInfoDraft RecurrenceInfo { get; set; }
    }
}
