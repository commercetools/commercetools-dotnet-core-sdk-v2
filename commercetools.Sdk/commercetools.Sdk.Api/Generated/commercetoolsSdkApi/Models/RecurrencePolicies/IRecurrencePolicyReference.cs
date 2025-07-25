using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.RecurrencePolicies
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.RecurrencePolicies.RecurrencePolicyReference))]
    public partial interface IRecurrencePolicyReference : IReference
    {
        IRecurrencePolicy Obj { get; set; }

        new string Id { get; set; }

    }
}
