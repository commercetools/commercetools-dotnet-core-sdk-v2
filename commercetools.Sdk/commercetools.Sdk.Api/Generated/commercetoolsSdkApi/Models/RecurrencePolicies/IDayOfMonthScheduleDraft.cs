using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.RecurrencePolicies
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.RecurrencePolicies.DayOfMonthScheduleDraft))]
    public partial interface IDayOfMonthScheduleDraft : IRecurrencePolicyScheduleDraft
    {
        int Day { get; set; }

    }
}
