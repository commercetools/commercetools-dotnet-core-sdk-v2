using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.RecurrencePolicies
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.RecurrencePolicies.StandardSchedule))]
    public partial interface IStandardSchedule : IRecurrencePolicySchedule
    {
        long Value { get; set; }

        IIntervalUnit IntervalUnit { get; set; }

    }
}
