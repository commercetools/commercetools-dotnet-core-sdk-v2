using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.TaxCategories;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CustomLineItem))]
    public partial interface ICustomLineItem
    {
        string Id { get; set; }

        ILocalizedString Name { get; set; }

        ITypedMoney Money { get; set; }

        ITaxedItemPrice TaxedPrice { get; set; }

        ITypedMoney TotalPrice { get; set; }

        string Slug { get; set; }

        long Quantity { get; set; }

        List<IItemState> State { get; set; }

        ITaxCategoryReference TaxCategory { get; set; }

        ITaxRate TaxRate { get; set; }

        List<IDiscountedLineItemPriceForQuantity> DiscountedPricePerQuantity { get; set; }

        ICustomFields Custom { get; set; }

        IItemShippingDetails ShippingDetails { get; set; }

        ICustomLineItemPriceMode PriceMode { get; set; }

    }
}
