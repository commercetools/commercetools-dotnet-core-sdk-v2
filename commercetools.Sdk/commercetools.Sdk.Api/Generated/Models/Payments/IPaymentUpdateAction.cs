using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [TypeDiscriminator(nameof(Action))]
    [SubTypeDiscriminator("addInterfaceInteraction", typeof(commercetools.Api.Models.Payments.PaymentAddInterfaceInteractionAction))]
    [SubTypeDiscriminator("addTransaction", typeof(commercetools.Api.Models.Payments.PaymentAddTransactionAction))]
    [SubTypeDiscriminator("changeAmountPlanned", typeof(commercetools.Api.Models.Payments.PaymentChangeAmountPlannedAction))]
    [SubTypeDiscriminator("changeTransactionInteractionId", typeof(commercetools.Api.Models.Payments.PaymentChangeTransactionInteractionIdAction))]
    [SubTypeDiscriminator("changeTransactionState", typeof(commercetools.Api.Models.Payments.PaymentChangeTransactionStateAction))]
    [SubTypeDiscriminator("changeTransactionTimestamp", typeof(commercetools.Api.Models.Payments.PaymentChangeTransactionTimestampAction))]
    [SubTypeDiscriminator("setAmountPaid", typeof(commercetools.Api.Models.Payments.PaymentSetAmountPaidAction))]
    [SubTypeDiscriminator("setAmountRefunded", typeof(commercetools.Api.Models.Payments.PaymentSetAmountRefundedAction))]
    [SubTypeDiscriminator("setAnonymousId", typeof(commercetools.Api.Models.Payments.PaymentSetAnonymousIdAction))]
    [SubTypeDiscriminator("setAuthorization", typeof(commercetools.Api.Models.Payments.PaymentSetAuthorizationAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Api.Models.Payments.PaymentSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Api.Models.Payments.PaymentSetCustomTypeAction))]
    [SubTypeDiscriminator("setCustomer", typeof(commercetools.Api.Models.Payments.PaymentSetCustomerAction))]
    [SubTypeDiscriminator("setExternalId", typeof(commercetools.Api.Models.Payments.PaymentSetExternalIdAction))]
    [SubTypeDiscriminator("setInterfaceId", typeof(commercetools.Api.Models.Payments.PaymentSetInterfaceIdAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Api.Models.Payments.PaymentSetKeyAction))]
    [SubTypeDiscriminator("setMethodInfoInterface", typeof(commercetools.Api.Models.Payments.PaymentSetMethodInfoInterfaceAction))]
    [SubTypeDiscriminator("setMethodInfoMethod", typeof(commercetools.Api.Models.Payments.PaymentSetMethodInfoMethodAction))]
    [SubTypeDiscriminator("setMethodInfoName", typeof(commercetools.Api.Models.Payments.PaymentSetMethodInfoNameAction))]
    [SubTypeDiscriminator("setStatusInterfaceCode", typeof(commercetools.Api.Models.Payments.PaymentSetStatusInterfaceCodeAction))]
    [SubTypeDiscriminator("setStatusInterfaceText", typeof(commercetools.Api.Models.Payments.PaymentSetStatusInterfaceTextAction))]
    [SubTypeDiscriminator("transitionState", typeof(commercetools.Api.Models.Payments.PaymentTransitionStateAction))]
    public partial interface IPaymentUpdateAction 
    {
        string Action { get; set;}
    }
}
