using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    public partial class StagedOrderAddLineItemAction : IStagedOrderAddLineItemAction
    {
        public string Action { get; set; }

        public ICustomFieldsDraft Custom { get; set; }

        public IChannelResourceIdentifier DistributionChannel { get; set; }

        public IExternalTaxRateDraft ExternalTaxRate { get; set; }

        public string ProductId { get; set; }

        public long? VariantId { get; set; }

        public string Sku { get; set; }

        public long? Quantity { get; set; }

        public DateTime? AddedAt { get; set; }

        public IChannelResourceIdentifier SupplyChannel { get; set; }

        public IMoney ExternalPrice { get; set; }

        public IExternalLineItemTotalPrice ExternalTotalPrice { get; set; }

        public IItemShippingDetailsDraft ShippingDetails { get; set; }
        public StagedOrderAddLineItemAction()
        {
            this.Action = "addLineItem";
        }
    }
}
