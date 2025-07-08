using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.RecurrencePolicies
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.RecurrencePolicies.StandardScheduleDraft))]
    public partial interface IStandardScheduleDraft : IRecurrencePolicyScheduleDraft
    {
        long Value { get; set; }

        IIntervalUnit IntervalUnit { get; set; }

    }
}
