using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.TaxCategories;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class LineItemImportDraft : ILineItemImportDraft
    {
        public string ProductId { get; set; }

        public ILocalizedString Name { get; set; }

        public IProductVariantImportDraft Variant { get; set; }

        public IPriceDraft Price { get; set; }

        public long Quantity { get; set; }

        public IList<IItemState> State { get; set; }
        public IEnumerable<IItemState> StateEnumerable { set => State = value.ToList(); }


        public IChannelResourceIdentifier SupplyChannel { get; set; }

        public IChannelResourceIdentifier DistributionChannel { get; set; }

        public ITaxRate TaxRate { get; set; }

        public ICustomFieldsDraft Custom { get; set; }

        public IInventoryMode InventoryMode { get; set; }

        public IItemShippingDetailsDraft ShippingDetails { get; set; }
    }
}
