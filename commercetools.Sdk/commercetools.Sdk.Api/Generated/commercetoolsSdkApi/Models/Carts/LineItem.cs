using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.ProductTypes;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Sdk.Api.Models.RecurringOrders;
using commercetools.Sdk.Api.Models.TaxCategories;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class LineItem : ILineItem
    {
        public string Id { get; set; }

        public string Key { get; set; }

        public string ProductId { get; set; }

        public string ProductKey { get; set; }

        public ILocalizedString Name { get; set; }

        public ILocalizedString ProductSlug { get; set; }

        public IProductTypeReference ProductType { get; set; }

        public IProductVariant Variant { get; set; }

        public IPrice Price { get; set; }

        public long Quantity { get; set; }

        public ICentPrecisionMoney TotalPrice { get; set; }

        public IList<IDiscountedLineItemPriceForQuantity> DiscountedPricePerQuantity { get; set; }

        public IEnumerable<IDiscountedLineItemPriceForQuantity> DiscountedPricePerQuantityEnumerable { set => DiscountedPricePerQuantity = value.ToList(); }

        public ITaxedItemPrice TaxedPrice { get; set; }

        public IList<IMethodTaxedPrice> TaxedPricePortions { get; set; }

        public IEnumerable<IMethodTaxedPrice> TaxedPricePortionsEnumerable { set => TaxedPricePortions = value.ToList(); }

        public IList<IItemState> State { get; set; }

        public IEnumerable<IItemState> StateEnumerable { set => State = value.ToList(); }

        public ITaxRate TaxRate { get; set; }

        public IList<IMethodTaxRate> PerMethodTaxRate { get; set; }

        public IEnumerable<IMethodTaxRate> PerMethodTaxRateEnumerable { set => PerMethodTaxRate = value.ToList(); }

        public IChannelReference SupplyChannel { get; set; }

        public IChannelReference DistributionChannel { get; set; }

        public ILineItemPriceMode PriceMode { get; set; }

        public ILineItemMode LineItemMode { get; set; }

        public IInventoryMode InventoryMode { get; set; }

        public IItemShippingDetails ShippingDetails { get; set; }

        public ICustomFields Custom { get; set; }

        public DateTime? AddedAt { get; set; }

        public DateTime? LastModifiedAt { get; set; }

        public ILineItemRecurrenceInfo RecurrenceInfo { get; set; }
    }
}
