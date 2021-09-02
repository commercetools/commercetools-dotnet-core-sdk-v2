using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderAddLineItemAction))]
    public partial interface IStagedOrderAddLineItemAction : IStagedOrderUpdateAction
    {
        ICustomFieldsDraft Custom { get; set; }

        IChannelResourceIdentifier DistributionChannel { get; set; }

        IExternalTaxRateDraft ExternalTaxRate { get; set; }

        string ProductId { get; set; }

        long? VariantId { get; set; }

        string Sku { get; set; }

        double? Quantity { get; set; }

        DateTime? AddedAt { get; set; }

        IChannelResourceIdentifier SupplyChannel { get; set; }

        IMoney ExternalPrice { get; set; }

        IExternalLineItemTotalPrice ExternalTotalPrice { get; set; }

        IItemShippingDetailsDraft ShippingDetails { get; set; }
    }
}
