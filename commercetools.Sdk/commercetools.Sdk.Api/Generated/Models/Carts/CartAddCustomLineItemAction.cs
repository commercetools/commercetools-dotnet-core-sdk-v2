using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.TaxCategories;
using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartAddCustomLineItemAction : ICartAddCustomLineItemAction
    {
        public string Action { get; set; }

        public IMoney Money { get; set; }

        public ILocalizedString Name { get; set; }

        public long? Quantity { get; set; }

        public string Slug { get; set; }

        public ITaxCategoryResourceIdentifier TaxCategory { get; set; }

        public IExternalTaxRateDraft ExternalTaxRate { get; set; }

        public IItemShippingDetailsDraft ShippingDetails { get; set; }

        public ICustomFieldsDraft Custom { get; set; }

        public ICustomLineItemPriceMode PriceMode { get; set; }
        public CartAddCustomLineItemAction()
        {
            this.Action = "addCustomLineItem";
        }
    }
}
