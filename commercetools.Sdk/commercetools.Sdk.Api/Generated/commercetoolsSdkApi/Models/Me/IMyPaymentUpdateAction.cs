using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Me.MyPaymentUpdateAction))]
    [SubTypeDiscriminator("addTransaction", typeof(commercetools.Sdk.Api.Models.Me.MyPaymentAddTransactionAction))]
    [SubTypeDiscriminator("changeAmountPlanned", typeof(commercetools.Sdk.Api.Models.Me.MyPaymentChangeAmountPlannedAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Sdk.Api.Models.Me.MyPaymentSetCustomFieldAction))]
    [SubTypeDiscriminator("setMethodInfoInterface", typeof(commercetools.Sdk.Api.Models.Me.MyPaymentSetMethodInfoInterfaceAction))]
    [SubTypeDiscriminator("setMethodInfoMethod", typeof(commercetools.Sdk.Api.Models.Me.MyPaymentSetMethodInfoMethodAction))]
    [SubTypeDiscriminator("setMethodInfoName", typeof(commercetools.Sdk.Api.Models.Me.MyPaymentSetMethodInfoNameAction))]
    [SubTypeDiscriminator("setTransactionCustomField", typeof(commercetools.Sdk.Api.Models.Me.MyPaymentSetTransactionCustomFieldAction))]
    public partial interface IMyPaymentUpdateAction
    {
        string Action { get; set; }

        static commercetools.Sdk.Api.Models.Me.MyPaymentAddTransactionAction AddTransaction(Action<commercetools.Sdk.Api.Models.Me.MyPaymentAddTransactionAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyPaymentAddTransactionAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyPaymentChangeAmountPlannedAction ChangeAmountPlanned(Action<commercetools.Sdk.Api.Models.Me.MyPaymentChangeAmountPlannedAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyPaymentChangeAmountPlannedAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyPaymentSetCustomFieldAction SetCustomField(Action<commercetools.Sdk.Api.Models.Me.MyPaymentSetCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyPaymentSetCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyPaymentSetMethodInfoInterfaceAction SetMethodInfoInterface(Action<commercetools.Sdk.Api.Models.Me.MyPaymentSetMethodInfoInterfaceAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyPaymentSetMethodInfoInterfaceAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyPaymentSetMethodInfoMethodAction SetMethodInfoMethod(Action<commercetools.Sdk.Api.Models.Me.MyPaymentSetMethodInfoMethodAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyPaymentSetMethodInfoMethodAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyPaymentSetMethodInfoNameAction SetMethodInfoName(Action<commercetools.Sdk.Api.Models.Me.MyPaymentSetMethodInfoNameAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyPaymentSetMethodInfoNameAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyPaymentSetTransactionCustomFieldAction SetTransactionCustomField(Action<commercetools.Sdk.Api.Models.Me.MyPaymentSetTransactionCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyPaymentSetTransactionCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
    }
}
