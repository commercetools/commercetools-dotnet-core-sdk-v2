using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.ProductTypes;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Sdk.Api.Models.TaxCategories;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.LineItem))]
    public partial interface ILineItem
    {
        string Id { get; set; }

        string ProductId { get; set; }

        string ProductKey { get; set; }

        ILocalizedString Name { get; set; }

        ILocalizedString ProductSlug { get; set; }

        IProductTypeReference ProductType { get; set; }

        IProductVariant Variant { get; set; }

        IPrice Price { get; set; }

        ITaxedItemPrice TaxedPrice { get; set; }

        List<IMethodTaxedPrice> TaxedPricePortions { get; set; }

        ITypedMoney TotalPrice { get; set; }

        long Quantity { get; set; }

        DateTime? AddedAt { get; set; }

        List<IItemState> State { get; set; }

        ITaxRate TaxRate { get; set; }

        List<IMethodTaxRate> PerMethodTaxRate { get; set; }

        IChannelReference SupplyChannel { get; set; }

        IChannelReference DistributionChannel { get; set; }

        List<IDiscountedLineItemPriceForQuantity> DiscountedPricePerQuantity { get; set; }

        ILineItemPriceMode PriceMode { get; set; }

        ILineItemMode LineItemMode { get; set; }

        ICustomFields Custom { get; set; }

        IInventoryMode InventoryMode { get; set; }

        IItemShippingDetails ShippingDetails { get; set; }

        DateTime? LastModifiedAt { get; set; }

    }
}
