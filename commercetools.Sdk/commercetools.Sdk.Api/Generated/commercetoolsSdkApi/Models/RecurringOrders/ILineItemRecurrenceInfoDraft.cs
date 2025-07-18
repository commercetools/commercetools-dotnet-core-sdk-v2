using commercetools.Sdk.Api.Models.RecurrencePolicies;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.RecurringOrders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.RecurringOrders.LineItemRecurrenceInfoDraft))]
    public partial interface ILineItemRecurrenceInfoDraft
    {
        IRecurrencePolicyResourceIdentifier RecurrencePolicy { get; set; }

        IPriceSelectionMode PriceSelectionMode { get; set; }

    }
}
