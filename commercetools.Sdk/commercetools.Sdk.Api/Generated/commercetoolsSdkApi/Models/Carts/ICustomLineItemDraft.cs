using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.RecurringOrders;
using commercetools.Sdk.Api.Models.TaxCategories;
using commercetools.Sdk.Api.Models.Types;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CustomLineItemDraft))]
    public partial interface ICustomLineItemDraft
    {
        ILocalizedString Name { get; set; }

        string Key { get; set; }

        long? Quantity { get; set; }

        IMoney Money { get; set; }

        string Slug { get; set; }

        ITaxCategoryResourceIdentifier TaxCategory { get; set; }

        IExternalTaxRateDraft ExternalTaxRate { get; set; }

        ICustomFieldsDraft Custom { get; set; }

        IItemShippingDetailsDraft ShippingDetails { get; set; }

        ICustomLineItemPriceMode PriceMode { get; set; }

        ICustomLineItemRecurrenceInfoDraft RecurrenceInfo { get; set; }

    }
}
