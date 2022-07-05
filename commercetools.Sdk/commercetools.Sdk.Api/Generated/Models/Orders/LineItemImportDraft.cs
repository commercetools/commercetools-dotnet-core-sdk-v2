using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.TaxCategories;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class LineItemImportDraft : ILineItemImportDraft
    {
        public string ProductId { get; set; }

        public ILocalizedString Name { get; set; }

        public IProductVariantImportDraft Variant { get; set; }

        public IPriceDraft Price { get; set; }

        public long Quantity { get; set; }

        public List<IItemState> State { get; set; }

        public IChannelResourceIdentifier SupplyChannel { get; set; }

        public IChannelResourceIdentifier DistributionChannel { get; set; }

        public ITaxRate TaxRate { get; set; }

        public ICustomFieldsDraft Custom { get; set; }

        public IItemShippingDetailsDraft ShippingDetails { get; set; }
    }
}
