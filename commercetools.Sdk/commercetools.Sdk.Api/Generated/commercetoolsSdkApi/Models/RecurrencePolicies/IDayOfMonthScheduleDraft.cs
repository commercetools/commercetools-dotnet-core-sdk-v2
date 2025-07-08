using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.RecurrencePolicies
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.RecurrencePolicies.DayOfMonthScheduleDraft))]
    public partial interface IDayOfMonthScheduleDraft : IRecurrencePolicyScheduleDraft
    {
        new string Type { get; set; }

        int Day { get; set; }

    }
}
