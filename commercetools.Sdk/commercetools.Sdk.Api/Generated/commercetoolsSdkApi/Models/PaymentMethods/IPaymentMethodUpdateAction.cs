using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.PaymentMethods
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodUpdateAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodSetCustomTypeAction))]
    [SubTypeDiscriminator("setDefault", typeof(commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodSetDefaultAction))]
    [SubTypeDiscriminator("setInterfaceAccount", typeof(commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodSetInterfaceAccountAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodSetKeyAction))]
    [SubTypeDiscriminator("setMethod", typeof(commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodSetMethodAction))]
    [SubTypeDiscriminator("setName", typeof(commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodSetNameAction))]
    [SubTypeDiscriminator("setPaymentInterface", typeof(commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodSetPaymentInterfaceAction))]
    [SubTypeDiscriminator("setPaymentMethodStatus", typeof(commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodSetPaymentMethodStatusAction))]
    public partial interface IPaymentMethodUpdateAction
    {
        string Action { get; set; }

        static commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodSetCustomFieldAction SetCustomField(Action<commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodSetCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodSetCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodSetCustomTypeAction SetCustomType(Action<commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodSetCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodSetCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodSetDefaultAction SetDefault(Action<commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodSetDefaultAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodSetDefaultAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodSetInterfaceAccountAction SetInterfaceAccount(Action<commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodSetInterfaceAccountAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodSetInterfaceAccountAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodSetKeyAction SetKey(Action<commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodSetKeyAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodSetKeyAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodSetMethodAction SetMethod(Action<commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodSetMethodAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodSetMethodAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodSetNameAction SetName(Action<commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodSetNameAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodSetNameAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodSetPaymentInterfaceAction SetPaymentInterface(Action<commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodSetPaymentInterfaceAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodSetPaymentInterfaceAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodSetPaymentMethodStatusAction SetPaymentMethodStatus(Action<commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodSetPaymentMethodStatusAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodSetPaymentMethodStatusAction();
            init?.Invoke(t);
            return t;
        }
    }
}
