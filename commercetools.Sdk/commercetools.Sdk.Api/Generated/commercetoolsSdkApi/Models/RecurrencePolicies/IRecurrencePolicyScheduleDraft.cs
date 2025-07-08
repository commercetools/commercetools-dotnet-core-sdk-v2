using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.RecurrencePolicies
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.RecurrencePolicies.RecurrencePolicyScheduleDraft))]
    [SubTypeDiscriminator("standard", typeof(commercetools.Sdk.Api.Models.RecurrencePolicies.StandardScheduleDraft))]
    public partial interface IRecurrencePolicyScheduleDraft
    {
        string Type { get; set; }

        static commercetools.Sdk.Api.Models.RecurrencePolicies.StandardScheduleDraft Standard(Action<commercetools.Sdk.Api.Models.RecurrencePolicies.StandardScheduleDraft> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.RecurrencePolicies.StandardScheduleDraft();
            init?.Invoke(t);
            return t;
        }
    }
}
