using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using commercetools.Api.Models.TaxCategories;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    public partial class LineItemImportDraft : ILineItemImportDraft
    {
        public string ProductId { get; set; }

        public ILocalizedString Name { get; set; }

        public IProductVariantImportDraft Variant { get; set; }

        public IPriceDraft Price { get; set; }

        public double Quantity { get; set; }

        public List<IItemState> State { get; set; }

        public IChannelResourceIdentifier SupplyChannel { get; set; }

        public IChannelResourceIdentifier DistributionChannel { get; set; }

        public ITaxRate TaxRate { get; set; }

        public ICustomFieldsDraft Custom { get; set; }

        public IItemShippingDetailsDraft ShippingDetails { get; set; }
    }
}
