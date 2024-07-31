using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Prices;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Orders.CustomLineItemDraft))]
    public partial interface ICustomLineItemDraft
    {
        ILocalizedString Name { get; set; }

        ITypedMoney Money { get; set; }

        ICustomLineItemTaxedPrice TaxedPrice { get; set; }

        ITypedMoney TotalPrice { get; set; }

        string Slug { get; set; }

        long Quantity { get; set; }

        IList<IItemState> State { get; set; }

        IEnumerable<IItemState> StateEnumerable { set => State = value.ToList(); }

        ITaxCategoryKeyReference TaxCategory { get; set; }

        ITaxRate TaxRate { get; set; }

        IExternalTaxRateDraft ExternalTaxRate { get; set; }

        IList<IDiscountedLineItemPriceDraft> DiscountedPricePerQuantity { get; set; }

        IEnumerable<IDiscountedLineItemPriceDraft> DiscountedPricePerQuantityEnumerable { set => DiscountedPricePerQuantity = value.ToList(); }

        IItemShippingDetailsDraft ShippingDetails { get; set; }

    }
}
