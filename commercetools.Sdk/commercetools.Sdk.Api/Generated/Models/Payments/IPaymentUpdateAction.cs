using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Payments
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Payments.PaymentUpdateAction))]
    [SubTypeDiscriminator("addInterfaceInteraction", typeof(commercetools.Sdk.Api.Models.Payments.PaymentAddInterfaceInteractionAction))]
    [SubTypeDiscriminator("addTransaction", typeof(commercetools.Sdk.Api.Models.Payments.PaymentAddTransactionAction))]
    [SubTypeDiscriminator("changeAmountPlanned", typeof(commercetools.Sdk.Api.Models.Payments.PaymentChangeAmountPlannedAction))]
    [SubTypeDiscriminator("changeTransactionInteractionId", typeof(commercetools.Sdk.Api.Models.Payments.PaymentChangeTransactionInteractionIdAction))]
    [SubTypeDiscriminator("changeTransactionState", typeof(commercetools.Sdk.Api.Models.Payments.PaymentChangeTransactionStateAction))]
    [SubTypeDiscriminator("changeTransactionTimestamp", typeof(commercetools.Sdk.Api.Models.Payments.PaymentChangeTransactionTimestampAction))]
    [SubTypeDiscriminator("setAnonymousId", typeof(commercetools.Sdk.Api.Models.Payments.PaymentSetAnonymousIdAction))]
    [SubTypeDiscriminator("setCustomer", typeof(commercetools.Sdk.Api.Models.Payments.PaymentSetCustomerAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Sdk.Api.Models.Payments.PaymentSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Sdk.Api.Models.Payments.PaymentSetCustomTypeAction))]
    [SubTypeDiscriminator("setInterfaceId", typeof(commercetools.Sdk.Api.Models.Payments.PaymentSetInterfaceIdAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Sdk.Api.Models.Payments.PaymentSetKeyAction))]
    [SubTypeDiscriminator("setMethodInfoInterface", typeof(commercetools.Sdk.Api.Models.Payments.PaymentSetMethodInfoInterfaceAction))]
    [SubTypeDiscriminator("setMethodInfoMethod", typeof(commercetools.Sdk.Api.Models.Payments.PaymentSetMethodInfoMethodAction))]
    [SubTypeDiscriminator("setMethodInfoName", typeof(commercetools.Sdk.Api.Models.Payments.PaymentSetMethodInfoNameAction))]
    [SubTypeDiscriminator("setStatusInterfaceCode", typeof(commercetools.Sdk.Api.Models.Payments.PaymentSetStatusInterfaceCodeAction))]
    [SubTypeDiscriminator("setStatusInterfaceText", typeof(commercetools.Sdk.Api.Models.Payments.PaymentSetStatusInterfaceTextAction))]
    [SubTypeDiscriminator("setTransactionCustomField", typeof(commercetools.Sdk.Api.Models.Payments.PaymentSetTransactionCustomFieldAction))]
    [SubTypeDiscriminator("setTransactionCustomType", typeof(commercetools.Sdk.Api.Models.Payments.PaymentSetTransactionCustomTypeAction))]
    [SubTypeDiscriminator("transitionState", typeof(commercetools.Sdk.Api.Models.Payments.PaymentTransitionStateAction))]
    public partial interface IPaymentUpdateAction
    {
        string Action { get; set; }

        static commercetools.Sdk.Api.Models.Payments.PaymentAddInterfaceInteractionAction AddInterfaceInteraction(Action<commercetools.Sdk.Api.Models.Payments.PaymentAddInterfaceInteractionAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Payments.PaymentAddInterfaceInteractionAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Payments.PaymentAddTransactionAction AddTransaction(Action<commercetools.Sdk.Api.Models.Payments.PaymentAddTransactionAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Payments.PaymentAddTransactionAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Payments.PaymentChangeAmountPlannedAction ChangeAmountPlanned(Action<commercetools.Sdk.Api.Models.Payments.PaymentChangeAmountPlannedAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Payments.PaymentChangeAmountPlannedAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Payments.PaymentChangeTransactionInteractionIdAction ChangeTransactionInteractionId(Action<commercetools.Sdk.Api.Models.Payments.PaymentChangeTransactionInteractionIdAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Payments.PaymentChangeTransactionInteractionIdAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Payments.PaymentChangeTransactionStateAction ChangeTransactionState(Action<commercetools.Sdk.Api.Models.Payments.PaymentChangeTransactionStateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Payments.PaymentChangeTransactionStateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Payments.PaymentChangeTransactionTimestampAction ChangeTransactionTimestamp(Action<commercetools.Sdk.Api.Models.Payments.PaymentChangeTransactionTimestampAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Payments.PaymentChangeTransactionTimestampAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Payments.PaymentSetAnonymousIdAction SetAnonymousId(Action<commercetools.Sdk.Api.Models.Payments.PaymentSetAnonymousIdAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Payments.PaymentSetAnonymousIdAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Payments.PaymentSetCustomerAction SetCustomer(Action<commercetools.Sdk.Api.Models.Payments.PaymentSetCustomerAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Payments.PaymentSetCustomerAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Payments.PaymentSetCustomFieldAction SetCustomField(Action<commercetools.Sdk.Api.Models.Payments.PaymentSetCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Payments.PaymentSetCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Payments.PaymentSetCustomTypeAction SetCustomType(Action<commercetools.Sdk.Api.Models.Payments.PaymentSetCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Payments.PaymentSetCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Payments.PaymentSetInterfaceIdAction SetInterfaceId(Action<commercetools.Sdk.Api.Models.Payments.PaymentSetInterfaceIdAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Payments.PaymentSetInterfaceIdAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Payments.PaymentSetKeyAction SetKey(Action<commercetools.Sdk.Api.Models.Payments.PaymentSetKeyAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Payments.PaymentSetKeyAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Payments.PaymentSetMethodInfoInterfaceAction SetMethodInfoInterface(Action<commercetools.Sdk.Api.Models.Payments.PaymentSetMethodInfoInterfaceAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Payments.PaymentSetMethodInfoInterfaceAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Payments.PaymentSetMethodInfoMethodAction SetMethodInfoMethod(Action<commercetools.Sdk.Api.Models.Payments.PaymentSetMethodInfoMethodAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Payments.PaymentSetMethodInfoMethodAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Payments.PaymentSetMethodInfoNameAction SetMethodInfoName(Action<commercetools.Sdk.Api.Models.Payments.PaymentSetMethodInfoNameAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Payments.PaymentSetMethodInfoNameAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Payments.PaymentSetStatusInterfaceCodeAction SetStatusInterfaceCode(Action<commercetools.Sdk.Api.Models.Payments.PaymentSetStatusInterfaceCodeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Payments.PaymentSetStatusInterfaceCodeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Payments.PaymentSetStatusInterfaceTextAction SetStatusInterfaceText(Action<commercetools.Sdk.Api.Models.Payments.PaymentSetStatusInterfaceTextAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Payments.PaymentSetStatusInterfaceTextAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Payments.PaymentSetTransactionCustomFieldAction SetTransactionCustomField(Action<commercetools.Sdk.Api.Models.Payments.PaymentSetTransactionCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Payments.PaymentSetTransactionCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Payments.PaymentSetTransactionCustomTypeAction SetTransactionCustomType(Action<commercetools.Sdk.Api.Models.Payments.PaymentSetTransactionCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Payments.PaymentSetTransactionCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Payments.PaymentTransitionStateAction TransitionState(Action<commercetools.Sdk.Api.Models.Payments.PaymentTransitionStateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Payments.PaymentTransitionStateAction();
            init?.Invoke(t);
            return t;
        }
    }
}
