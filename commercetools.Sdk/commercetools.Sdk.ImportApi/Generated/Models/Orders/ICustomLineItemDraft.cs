using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Orders;
using commercetools.ImportApi.Models.Prices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Orders.CustomLineItemDraft))]
    public partial interface ICustomLineItemDraft
    {
        ILocalizedString Name { get; set; }

        ITypedMoney Money { get; set; }

        ICustomLineItemTaxedPrice TaxedPrice { get; set; }

        ITypedMoney TotalPrice { get; set; }

        string Slug { get; set; }

        double Quantity { get; set; }

        List<IItemState> State { get; set; }

        ITaxCategoryKeyReference TaxCategory { get; set; }

        ITaxRate TaxRate { get; set; }

        IExternalTaxRateDraft ExternalTaxRate { get; set; }

        List<IDiscountedLineItemPriceDraft> DiscountedPricePerQuantity { get; set; }

        IItemShippingDetailsDraft ShippingDetails { get; set; }
    }
}
