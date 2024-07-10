using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Prices;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.ImportApi.Models.Orders
{

    public partial class CustomLineItemDraft : ICustomLineItemDraft
    {
        public ILocalizedString Name { get; set; }

        public ITypedMoney Money { get; set; }

        public ICustomLineItemTaxedPrice TaxedPrice { get; set; }

        public ITypedMoney TotalPrice { get; set; }

        public string Slug { get; set; }

        public long Quantity { get; set; }

        public IList<IItemState> State { get; set; }
        public IEnumerable<IItemState> StateEnumerable { set => State = value.ToList(); }


        public ITaxCategoryKeyReference TaxCategory { get; set; }

        public ITaxRate TaxRate { get; set; }

        public IExternalTaxRateDraft ExternalTaxRate { get; set; }

        public IList<IDiscountedLineItemPriceDraft> DiscountedPricePerQuantity { get; set; }
        public IEnumerable<IDiscountedLineItemPriceDraft> DiscountedPricePerQuantityEnumerable { set => DiscountedPricePerQuantity = value.ToList(); }


        public IItemShippingDetailsDraft ShippingDetails { get; set; }
    }
}
