using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.RecurrencePolicies
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.RecurrencePolicies.RecurrencePolicySetKeyAction))]
    public partial interface IRecurrencePolicySetKeyAction : IRecurrencePolicyUpdateAction
    {
        string Key { get; set; }

    }
}
