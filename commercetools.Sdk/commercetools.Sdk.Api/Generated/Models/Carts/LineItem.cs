using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.ProductTypes;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Sdk.Api.Models.TaxCategories;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class LineItem : ILineItem
    {
        public string Id { get; set; }

        public string ProductId { get; set; }

        public string ProductKey { get; set; }

        public ILocalizedString Name { get; set; }

        public ILocalizedString ProductSlug { get; set; }

        public IProductTypeReference ProductType { get; set; }

        public IProductVariant Variant { get; set; }

        public IPrice Price { get; set; }

        public ITaxedItemPrice TaxedPrice { get; set; }

        public ITypedMoney TotalPrice { get; set; }

        public long Quantity { get; set; }

        public DateTime? AddedAt { get; set; }

        public List<IItemState> State { get; set; }

        public ITaxRate TaxRate { get; set; }

        public IChannelReference SupplyChannel { get; set; }

        public IChannelReference DistributionChannel { get; set; }

        public List<IDiscountedLineItemPriceForQuantity> DiscountedPricePerQuantity { get; set; }

        public ILineItemPriceMode PriceMode { get; set; }

        public ILineItemMode LineItemMode { get; set; }

        public ICustomFields Custom { get; set; }

        public IInventoryMode InventoryMode { get; set; }

        public IItemShippingDetails ShippingDetails { get; set; }

        public DateTime? LastModifiedAt { get; set; }
    }
}
