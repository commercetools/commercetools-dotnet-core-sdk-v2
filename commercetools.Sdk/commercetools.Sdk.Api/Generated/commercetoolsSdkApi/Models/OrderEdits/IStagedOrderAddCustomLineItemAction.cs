using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.RecurringOrders;
using commercetools.Sdk.Api.Models.TaxCategories;
using commercetools.Sdk.Api.Models.Types;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderAddCustomLineItemAction))]
    public partial interface IStagedOrderAddCustomLineItemAction : IStagedOrderUpdateAction
    {
        IMoney Money { get; set; }

        ILocalizedString Name { get; set; }

        string Key { get; set; }

        long? Quantity { get; set; }

        string Slug { get; set; }

        ITaxCategoryResourceIdentifier TaxCategory { get; set; }

        IExternalTaxRateDraft ExternalTaxRate { get; set; }

        IItemShippingDetailsDraft ShippingDetails { get; set; }

        ICustomLineItemPriceMode PriceMode { get; set; }

        ICustomFieldsDraft Custom { get; set; }

        ICustomLineItemRecurrenceInfoDraft RecurrenceInfo { get; set; }

    }
}
