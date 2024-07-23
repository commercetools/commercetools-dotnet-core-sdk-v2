using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Types;
using System;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyLineItemDraft : IMyLineItemDraft
    {
        public string Key { get; set; }

        public string ProductId { get; set; }

        public long? VariantId { get; set; }

        public string Sku { get; set; }

        public long? Quantity { get; set; }

        public DateTime? AddedAt { get; set; }

        public IChannelResourceIdentifier SupplyChannel { get; set; }

        public IChannelResourceIdentifier DistributionChannel { get; set; }

        public IItemShippingDetailsDraft ShippingDetails { get; set; }

        public ICustomFieldsDraft Custom { get; set; }
    }
}
