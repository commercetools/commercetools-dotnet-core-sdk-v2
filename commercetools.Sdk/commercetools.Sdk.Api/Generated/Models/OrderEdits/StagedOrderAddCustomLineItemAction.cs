using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.TaxCategories;
using commercetools.Api.Models.Types;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderAddCustomLineItemAction : IStagedOrderAddCustomLineItemAction
    {
        public string Action { get; set; }

        public IMoney Money { get; set; }

        public ILocalizedString Name { get; set; }

        public double? Quantity { get; set; }

        public string Slug { get; set; }

        public ITaxCategoryResourceIdentifier TaxCategory { get; set; }

        public ICustomFieldsDraft Custom { get; set; }

        public IExternalTaxRateDraft ExternalTaxRate { get; set; }
        public StagedOrderAddCustomLineItemAction()
        {
            this.Action = "addCustomLineItem";
        }
    }
}
