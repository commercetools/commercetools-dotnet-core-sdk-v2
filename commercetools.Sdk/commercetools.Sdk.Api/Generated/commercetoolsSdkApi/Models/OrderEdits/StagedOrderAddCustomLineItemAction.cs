using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.RecurringOrders;
using commercetools.Sdk.Api.Models.TaxCategories;
using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderAddCustomLineItemAction : IStagedOrderAddCustomLineItemAction
    {
        public string Action { get; set; }

        public IMoney Money { get; set; }

        public ILocalizedString Name { get; set; }

        public string Key { get; set; }

        public long? Quantity { get; set; }

        public string Slug { get; set; }

        public ITaxCategoryResourceIdentifier TaxCategory { get; set; }

        public IExternalTaxRateDraft ExternalTaxRate { get; set; }

        public IItemShippingDetailsDraft ShippingDetails { get; set; }

        public ICustomLineItemPriceMode PriceMode { get; set; }

        public ICustomFieldsDraft Custom { get; set; }

        public ICustomLineItemRecurrenceInfoDraft RecurrenceInfo { get; set; }
        public StagedOrderAddCustomLineItemAction()
        {
            this.Action = "addCustomLineItem";
        }
    }
}
