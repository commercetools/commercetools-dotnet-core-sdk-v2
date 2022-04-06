using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Prices;
using System.Collections.Generic;


namespace commercetools.Sdk.ImportApi.Models.Orders
{
    public partial class CustomLineItemDraft : ICustomLineItemDraft
    {
        public ILocalizedString Name { get; set; }

        public ITypedMoney Money { get; set; }

        public ICustomLineItemTaxedPrice TaxedPrice { get; set; }

        public ITypedMoney TotalPrice { get; set; }

        public string Slug { get; set; }

        public double Quantity { get; set; }

        public List<IItemState> State { get; set; }

        public ITaxCategoryKeyReference TaxCategory { get; set; }

        public ITaxRate TaxRate { get; set; }

        public IExternalTaxRateDraft ExternalTaxRate { get; set; }

        public List<IDiscountedLineItemPriceDraft> DiscountedPricePerQuantity { get; set; }

        public IItemShippingDetailsDraft ShippingDetails { get; set; }
    }
}
