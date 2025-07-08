using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.RecurrencePolicies
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.RecurrencePolicies.DayOfMonthSchedule))]
    public partial interface IDayOfMonthSchedule : IRecurrencePolicySchedule
    {
        new string Type { get; set; }

        int Day { get; set; }

    }
}
