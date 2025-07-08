using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.RecurrencePolicies
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.RecurrencePolicies.RecurrencePolicySchedule))]
    [SubTypeDiscriminator("dayOfMonth", typeof(commercetools.Sdk.Api.Models.RecurrencePolicies.DayOfMonthSchedule))]
    [SubTypeDiscriminator("standard", typeof(commercetools.Sdk.Api.Models.RecurrencePolicies.StandardSchedule))]
    public partial interface IRecurrencePolicySchedule
    {
        string Type { get; set; }

        static commercetools.Sdk.Api.Models.RecurrencePolicies.DayOfMonthSchedule DayOfMonth(Action<commercetools.Sdk.Api.Models.RecurrencePolicies.DayOfMonthSchedule> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.RecurrencePolicies.DayOfMonthSchedule();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.RecurrencePolicies.StandardSchedule Standard(Action<commercetools.Sdk.Api.Models.RecurrencePolicies.StandardSchedule> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.RecurrencePolicies.StandardSchedule();
            init?.Invoke(t);
            return t;
        }
    }
}
