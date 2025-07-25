using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.RecurringOrders
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderUpdateAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderSetCustomTypeAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderSetKeyAction))]
    [SubTypeDiscriminator("setOrderSkipConfiguration", typeof(commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderSetOrderSkipConfigurationAction))]
    [SubTypeDiscriminator("setRecurringOrderState", typeof(commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderSetStateAction))]
    [SubTypeDiscriminator("setSchedule", typeof(commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderSetScheduleAction))]
    [SubTypeDiscriminator("setStartsAt", typeof(commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderSetStartsAtAction))]
    [SubTypeDiscriminator("transitionState", typeof(commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderTransitionStateAction))]
    public partial interface IRecurringOrderUpdateAction
    {
        string Action { get; set; }

        static commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderSetCustomFieldAction SetCustomField(Action<commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderSetCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderSetCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderSetCustomTypeAction SetCustomType(Action<commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderSetCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderSetCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderSetKeyAction SetKey(Action<commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderSetKeyAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderSetKeyAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderSetOrderSkipConfigurationAction SetOrderSkipConfiguration(Action<commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderSetOrderSkipConfigurationAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderSetOrderSkipConfigurationAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderSetStateAction SetRecurringOrderState(Action<commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderSetStateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderSetStateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderSetScheduleAction SetSchedule(Action<commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderSetScheduleAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderSetScheduleAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderSetStartsAtAction SetStartsAt(Action<commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderSetStartsAtAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderSetStartsAtAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderTransitionStateAction TransitionState(Action<commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderTransitionStateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderTransitionStateAction();
            init?.Invoke(t);
            return t;
        }
    }
}
