using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.RecurringOrders
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderStateDraft))]
    [SubTypeDiscriminator("active", typeof(commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderActive))]
    [SubTypeDiscriminator("canceled", typeof(commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderCanceled))]
    [SubTypeDiscriminator("expired", typeof(commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderExpired))]
    [SubTypeDiscriminator("paused", typeof(commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderPaused))]
    public partial interface IRecurringOrderStateDraft
    {
        string Type { get; set; }

        static commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderActive Active(Action<commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderActive> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderActive();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderCanceled Canceled(Action<commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderCanceled> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderCanceled();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderExpired Expired(Action<commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderExpired> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderExpired();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderPaused Paused(Action<commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderPaused> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderPaused();
            init?.Invoke(t);
            return t;
        }
    }
}
