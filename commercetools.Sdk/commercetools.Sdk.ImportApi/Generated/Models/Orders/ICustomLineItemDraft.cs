using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Prices;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


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

        decimal Quantity { get; set; }

        List<IItemState> State { get; set; }

        ITaxCategoryKeyReference TaxCategory { get; set; }

        ITaxRate TaxRate { get; set; }

        IExternalTaxRateDraft ExternalTaxRate { get; set; }

        List<IDiscountedLineItemPriceDraft> DiscountedPricePerQuantity { get; set; }

        IItemShippingDetailsDraft ShippingDetails { get; set; }

    }
}
