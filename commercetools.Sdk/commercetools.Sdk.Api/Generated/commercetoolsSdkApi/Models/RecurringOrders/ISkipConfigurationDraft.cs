using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.RecurringOrders
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.RecurringOrders.SkipConfigurationDraft))]
    [SubTypeDiscriminator("counter", typeof(commercetools.Sdk.Api.Models.RecurringOrders.CounterDraft))]
    public partial interface ISkipConfigurationDraft
    {
        string Type { get; set; }

        static commercetools.Sdk.Api.Models.RecurringOrders.CounterDraft Counter(Action<commercetools.Sdk.Api.Models.RecurringOrders.CounterDraft> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.RecurringOrders.CounterDraft();
            init?.Invoke(t);
            return t;
        }
    }
}
