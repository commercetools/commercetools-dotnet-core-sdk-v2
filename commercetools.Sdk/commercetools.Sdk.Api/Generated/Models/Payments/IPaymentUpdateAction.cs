using commercetools.Base.CustomAttributes;


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
    [SubTypeDiscriminator("setAmountPaid", typeof(commercetools.Sdk.Api.Models.Payments.PaymentSetAmountPaidAction))]
    [SubTypeDiscriminator("setAmountRefunded", typeof(commercetools.Sdk.Api.Models.Payments.PaymentSetAmountRefundedAction))]
    [SubTypeDiscriminator("setAnonymousId", typeof(commercetools.Sdk.Api.Models.Payments.PaymentSetAnonymousIdAction))]
    [SubTypeDiscriminator("setAuthorization", typeof(commercetools.Sdk.Api.Models.Payments.PaymentSetAuthorizationAction))]
    [SubTypeDiscriminator("setCustomer", typeof(commercetools.Sdk.Api.Models.Payments.PaymentSetCustomerAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Sdk.Api.Models.Payments.PaymentSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Sdk.Api.Models.Payments.PaymentSetCustomTypeAction))]
    [SubTypeDiscriminator("setExternalId", typeof(commercetools.Sdk.Api.Models.Payments.PaymentSetExternalIdAction))]
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
    }
}
