using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.RecurrencePolicies
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.RecurrencePolicies.RecurrencePolicySetScheduleAction))]
    public partial interface IRecurrencePolicySetScheduleAction : IRecurrencePolicyUpdateAction
    {
        IRecurrencePolicyScheduleDraft Schedule { get; set; }

    }
}
