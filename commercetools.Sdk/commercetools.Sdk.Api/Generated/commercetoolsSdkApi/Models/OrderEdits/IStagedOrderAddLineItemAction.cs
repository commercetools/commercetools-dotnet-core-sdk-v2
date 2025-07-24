using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.RecurringOrders;
using commercetools.Sdk.Api.Models.Types;
using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderAddLineItemAction))]
    public partial interface IStagedOrderAddLineItemAction : IStagedOrderUpdateAction
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

        IInventoryMode InventoryMode { get; set; }

        IItemShippingDetailsDraft ShippingDetails { get; set; }

        ICustomFieldsDraft Custom { get; set; }

        ILineItemRecurrenceInfoDraft RecurrenceInfo { get; set; }

    }
}
