using commercetools.Sdk.Api.Models.RecurrencePolicies;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.RecurringOrders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.RecurringOrders.CustomLineItemRecurrenceInfo))]
    public partial interface ICustomLineItemRecurrenceInfo
    {
        IRecurrencePolicyReference RecurrencePolicy { get; set; }

    }
}
