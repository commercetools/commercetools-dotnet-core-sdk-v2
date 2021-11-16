using commercetools.Api.Models.Common;
using commercetools.Api.Models.TaxCategories;
using commercetools.Api.Models.Types;


namespace commercetools.Api.Models.Carts
{
    public partial class CustomLineItemDraft : ICustomLineItemDraft
    {
        public ILocalizedString Name { get; set; }

        public long Quantity { get; set; }

        public IMoney Money { get; set; }

        public string Slug { get; set; }

        public ITaxCategoryResourceIdentifier TaxCategory { get; set; }

        public IExternalTaxRateDraft ExternalTaxRate { get; set; }

        public ICustomFieldsDraft Custom { get; set; }

        public IItemShippingDetailsDraft ShippingDetails { get; set; }
    }
}
