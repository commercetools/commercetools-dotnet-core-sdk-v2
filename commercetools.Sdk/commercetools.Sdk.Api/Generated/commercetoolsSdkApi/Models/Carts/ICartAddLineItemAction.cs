using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.RecurringOrders;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartAddLineItemAction))]
    public partial interface ICartAddLineItemAction : ICartUpdateAction
    {
        string Key { get; set; }

        string ProductId { get; set; }

        long? VariantId { get; set; }

        string Sku { get; set; }

        long? Quantity { get; set; }

        DateTime? AddedAt { get; set; }

        IChannelResourceIdentifier DistributionChannel { get; set; }

        IChannelResourceIdentifier SupplyChannel { get; set; }

        IMoney ExternalPrice { get; set; }

        IExternalLineItemTotalPrice ExternalTotalPrice { get; set; }

        IExternalTaxRateDraft ExternalTaxRate { get; set; }

        IList<IMethodExternalTaxRateDraft> PerMethodExternalTaxRate { get; set; }

        IEnumerable<IMethodExternalTaxRateDraft> PerMethodExternalTaxRateEnumerable { set => PerMethodExternalTaxRate = value.ToList(); }

        IInventoryMode InventoryMode { get; set; }

        IItemShippingDetailsDraft ShippingDetails { get; set; }

        ILineItemRecurrenceInfoDraft RecurrenceInfo { get; set; }

        ICustomFieldsDraft Custom { get; set; }

    }
}
