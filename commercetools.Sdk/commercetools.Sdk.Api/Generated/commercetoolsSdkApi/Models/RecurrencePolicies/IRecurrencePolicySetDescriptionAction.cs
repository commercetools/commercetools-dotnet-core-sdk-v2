using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.RecurrencePolicies
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.RecurrencePolicies.RecurrencePolicySetDescriptionAction))]
    public partial interface IRecurrencePolicySetDescriptionAction : IRecurrencePolicyUpdateAction
    {
        ILocalizedString Description { get; set; }

    }
}
