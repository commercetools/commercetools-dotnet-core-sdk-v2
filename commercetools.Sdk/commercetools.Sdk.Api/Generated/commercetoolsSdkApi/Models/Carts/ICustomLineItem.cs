using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.TaxCategories;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CustomLineItem))]
    public partial interface ICustomLineItem
    {
        string Id { get; set; }

        string Key { get; set; }

        ILocalizedString Name { get; set; }

        ITypedMoney Money { get; set; }

        ITaxedItemPrice TaxedPrice { get; set; }

        IList<IMethodTaxedPrice> TaxedPricePortions { get; set; }

        IEnumerable<IMethodTaxedPrice> TaxedPricePortionsEnumerable { set => TaxedPricePortions = value.ToList(); }

        ICentPrecisionMoney TotalPrice { get; set; }

        string Slug { get; set; }

        long Quantity { get; set; }

        IList<IItemState> State { get; set; }

        IEnumerable<IItemState> StateEnumerable { set => State = value.ToList(); }

        ITaxCategoryReference TaxCategory { get; set; }

        ITaxRate TaxRate { get; set; }

        IList<IMethodTaxRate> PerMethodTaxRate { get; set; }

        IEnumerable<IMethodTaxRate> PerMethodTaxRateEnumerable { set => PerMethodTaxRate = value.ToList(); }

        IList<IDiscountedLineItemPriceForQuantity> DiscountedPricePerQuantity { get; set; }

        IEnumerable<IDiscountedLineItemPriceForQuantity> DiscountedPricePerQuantityEnumerable { set => DiscountedPricePerQuantity = value.ToList(); }

        ICustomFields Custom { get; set; }

        IItemShippingDetails ShippingDetails { get; set; }

        ICustomLineItemPriceMode PriceMode { get; set; }

    }
}
