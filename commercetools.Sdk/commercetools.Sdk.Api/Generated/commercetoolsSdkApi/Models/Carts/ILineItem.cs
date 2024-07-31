using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.ProductTypes;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Sdk.Api.Models.TaxCategories;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.LineItem))]
    public partial interface ILineItem
    {
        string Id { get; set; }

        string Key { get; set; }

        string ProductId { get; set; }

        string ProductKey { get; set; }

        ILocalizedString Name { get; set; }

        ILocalizedString ProductSlug { get; set; }

        IProductTypeReference ProductType { get; set; }

        IProductVariant Variant { get; set; }

        IPrice Price { get; set; }

        long Quantity { get; set; }

        ICentPrecisionMoney TotalPrice { get; set; }

        IList<IDiscountedLineItemPriceForQuantity> DiscountedPricePerQuantity { get; set; }

        IEnumerable<IDiscountedLineItemPriceForQuantity> DiscountedPricePerQuantityEnumerable { set => DiscountedPricePerQuantity = value.ToList(); }

        ITaxedItemPrice TaxedPrice { get; set; }

        IList<IMethodTaxedPrice> TaxedPricePortions { get; set; }

        IEnumerable<IMethodTaxedPrice> TaxedPricePortionsEnumerable { set => TaxedPricePortions = value.ToList(); }

        IList<IItemState> State { get; set; }

        IEnumerable<IItemState> StateEnumerable { set => State = value.ToList(); }

        ITaxRate TaxRate { get; set; }

        IList<IMethodTaxRate> PerMethodTaxRate { get; set; }

        IEnumerable<IMethodTaxRate> PerMethodTaxRateEnumerable { set => PerMethodTaxRate = value.ToList(); }

        IChannelReference SupplyChannel { get; set; }

        IChannelReference DistributionChannel { get; set; }

        ILineItemPriceMode PriceMode { get; set; }

        ILineItemMode LineItemMode { get; set; }

        IInventoryMode InventoryMode { get; set; }

        IItemShippingDetails ShippingDetails { get; set; }

        ICustomFields Custom { get; set; }

        DateTime? AddedAt { get; set; }

        DateTime? LastModifiedAt { get; set; }

    }
}
