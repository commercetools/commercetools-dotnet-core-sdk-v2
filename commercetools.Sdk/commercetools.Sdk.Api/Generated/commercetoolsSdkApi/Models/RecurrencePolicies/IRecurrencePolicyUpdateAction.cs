using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.RecurrencePolicies
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.RecurrencePolicies.RecurrencePolicyUpdateAction))]
    [SubTypeDiscriminator("setDescription", typeof(commercetools.Sdk.Api.Models.RecurrencePolicies.RecurrencePolicySetDescriptionAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Sdk.Api.Models.RecurrencePolicies.RecurrencePolicySetKeyAction))]
    [SubTypeDiscriminator("setName", typeof(commercetools.Sdk.Api.Models.RecurrencePolicies.RecurrencePolicySetNameAction))]
    [SubTypeDiscriminator("setSchedule", typeof(commercetools.Sdk.Api.Models.RecurrencePolicies.RecurrencePolicySetScheduleAction))]
    public partial interface IRecurrencePolicyUpdateAction
    {
        string Action { get; set; }

        static commercetools.Sdk.Api.Models.RecurrencePolicies.RecurrencePolicySetDescriptionAction SetDescription(Action<commercetools.Sdk.Api.Models.RecurrencePolicies.RecurrencePolicySetDescriptionAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.RecurrencePolicies.RecurrencePolicySetDescriptionAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.RecurrencePolicies.RecurrencePolicySetKeyAction SetKey(Action<commercetools.Sdk.Api.Models.RecurrencePolicies.RecurrencePolicySetKeyAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.RecurrencePolicies.RecurrencePolicySetKeyAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.RecurrencePolicies.RecurrencePolicySetNameAction SetName(Action<commercetools.Sdk.Api.Models.RecurrencePolicies.RecurrencePolicySetNameAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.RecurrencePolicies.RecurrencePolicySetNameAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.RecurrencePolicies.RecurrencePolicySetScheduleAction SetSchedule(Action<commercetools.Sdk.Api.Models.RecurrencePolicies.RecurrencePolicySetScheduleAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.RecurrencePolicies.RecurrencePolicySetScheduleAction();
            init?.Invoke(t);
            return t;
        }
    }
}
