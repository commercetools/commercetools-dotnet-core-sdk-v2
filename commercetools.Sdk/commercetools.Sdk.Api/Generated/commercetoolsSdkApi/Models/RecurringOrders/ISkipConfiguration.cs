using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.RecurringOrders
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.RecurringOrders.SkipConfiguration))]
    [SubTypeDiscriminator("Counter", typeof(commercetools.Sdk.Api.Models.RecurringOrders.Counter))]
    public partial interface ISkipConfiguration
    {
        string Type { get; set; }

        static commercetools.Sdk.Api.Models.RecurringOrders.Counter Counter(Action<commercetools.Sdk.Api.Models.RecurringOrders.Counter> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.RecurringOrders.Counter();
            init?.Invoke(t);
            return t;
        }
    }
}
