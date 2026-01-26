using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.RecurringOrders
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderScope))]
    [SubTypeDiscriminator("AnyOrder", typeof(commercetools.Sdk.Api.Models.RecurringOrders.AnyOrder))]
    [SubTypeDiscriminator("ApplicableRecurrencePolicies", typeof(commercetools.Sdk.Api.Models.RecurringOrders.ApplicableRecurrencePolicies))]
    [SubTypeDiscriminator("NonRecurringOrdersOnly", typeof(commercetools.Sdk.Api.Models.RecurringOrders.NonRecurringOrdersOnly))]
    [SubTypeDiscriminator("RecurringOrdersOnly", typeof(commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrdersOnly))]
    public partial interface IRecurringOrderScope
    {
        string Type { get; set; }

        static commercetools.Sdk.Api.Models.RecurringOrders.AnyOrder AnyOrder(Action<commercetools.Sdk.Api.Models.RecurringOrders.AnyOrder> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.RecurringOrders.AnyOrder();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.RecurringOrders.ApplicableRecurrencePolicies ApplicableRecurrencePolicies(Action<commercetools.Sdk.Api.Models.RecurringOrders.ApplicableRecurrencePolicies> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.RecurringOrders.ApplicableRecurrencePolicies();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.RecurringOrders.NonRecurringOrdersOnly NonRecurringOrdersOnly(Action<commercetools.Sdk.Api.Models.RecurringOrders.NonRecurringOrdersOnly> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.RecurringOrders.NonRecurringOrdersOnly();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrdersOnly RecurringOrdersOnly(Action<commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrdersOnly> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrdersOnly();
            init?.Invoke(t);
            return t;
        }
    }
}
