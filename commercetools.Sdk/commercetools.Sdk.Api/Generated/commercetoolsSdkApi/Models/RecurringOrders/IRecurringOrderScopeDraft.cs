using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.RecurringOrders
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderScopeDraft))]
    [SubTypeDiscriminator("AnyOrder", typeof(commercetools.Sdk.Api.Models.RecurringOrders.AnyOrderDraft))]
    [SubTypeDiscriminator("ApplicableRecurrencePolicies", typeof(commercetools.Sdk.Api.Models.RecurringOrders.ApplicableRecurrencePoliciesDraft))]
    [SubTypeDiscriminator("NonRecurringOrdersOnly", typeof(commercetools.Sdk.Api.Models.RecurringOrders.NonRecurringOrdersOnlyDraft))]
    [SubTypeDiscriminator("RecurringOrdersOnly", typeof(commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrdersOnlyDraft))]
    public partial interface IRecurringOrderScopeDraft
    {
        string Type { get; set; }

        static commercetools.Sdk.Api.Models.RecurringOrders.AnyOrderDraft AnyOrder(Action<commercetools.Sdk.Api.Models.RecurringOrders.AnyOrderDraft> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.RecurringOrders.AnyOrderDraft();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.RecurringOrders.ApplicableRecurrencePoliciesDraft ApplicableRecurrencePolicies(Action<commercetools.Sdk.Api.Models.RecurringOrders.ApplicableRecurrencePoliciesDraft> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.RecurringOrders.ApplicableRecurrencePoliciesDraft();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.RecurringOrders.NonRecurringOrdersOnlyDraft NonRecurringOrdersOnly(Action<commercetools.Sdk.Api.Models.RecurringOrders.NonRecurringOrdersOnlyDraft> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.RecurringOrders.NonRecurringOrdersOnlyDraft();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrdersOnlyDraft RecurringOrdersOnly(Action<commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrdersOnlyDraft> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrdersOnlyDraft();
            init?.Invoke(t);
            return t;
        }
    }
}
