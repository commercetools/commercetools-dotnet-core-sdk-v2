using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Prices;
using System.Collections.Generic;


namespace commercetools.Sdk.ImportApi.Models.Orders
{
    public partial class LineItemImportDraft : ILineItemImportDraft
    {
        public IProductKeyReference Product { get; set; }

        public ILocalizedString Name { get; set; }

        public ILineItemProductVariantImportDraft Variant { get; set; }

        public ILineItemPrice Price { get; set; }

        public double Quantity { get; set; }

        public List<IItemState> State { get; set; }

        public IChannelKeyReference SupplyChannel { get; set; }

        public IChannelKeyReference DistributionChannel { get; set; }

        public ITaxRate TaxRate { get; set; }

        public IItemShippingDetailsDraft ShippingDetails { get; set; }
    }
}
