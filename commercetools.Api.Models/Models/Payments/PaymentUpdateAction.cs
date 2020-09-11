using commercetools.Api.Models.Payments;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Payments
{
    [JsonConverter(typeof(JsonSubtypes), "action")]
    [JsonSubtypes.KnownSubType(typeof(PaymentAddInterfaceInteractionAction), "addInterfaceInteraction")]
    [JsonSubtypes.KnownSubType(typeof(PaymentAddTransactionAction), "addTransaction")]
    [JsonSubtypes.KnownSubType(typeof(PaymentChangeAmountPlannedAction), "changeAmountPlanned")]
    [JsonSubtypes.KnownSubType(typeof(PaymentChangeTransactionInteractionIdAction), "changeTransactionInteractionId")]
    [JsonSubtypes.KnownSubType(typeof(PaymentChangeTransactionStateAction), "changeTransactionState")]
    [JsonSubtypes.KnownSubType(typeof(PaymentChangeTransactionTimestampAction), "changeTransactionTimestamp")]
    [JsonSubtypes.KnownSubType(typeof(PaymentSetAmountPaidAction), "setAmountPaid")]
    [JsonSubtypes.KnownSubType(typeof(PaymentSetAmountRefundedAction), "setAmountRefunded")]
    [JsonSubtypes.KnownSubType(typeof(PaymentSetAnonymousIdAction), "setAnonymousId")]
    [JsonSubtypes.KnownSubType(typeof(PaymentSetAuthorizationAction), "setAuthorization")]
    [JsonSubtypes.KnownSubType(typeof(PaymentSetCustomFieldAction), "setCustomField")]
    [JsonSubtypes.KnownSubType(typeof(PaymentSetCustomTypeAction), "setCustomType")]
    [JsonSubtypes.KnownSubType(typeof(PaymentSetCustomerAction), "setCustomer")]
    [JsonSubtypes.KnownSubType(typeof(PaymentSetExternalIdAction), "setExternalId")]
    [JsonSubtypes.KnownSubType(typeof(PaymentSetInterfaceIdAction), "setInterfaceId")]
    [JsonSubtypes.KnownSubType(typeof(PaymentSetKeyAction), "setKey")]
    [JsonSubtypes.KnownSubType(typeof(PaymentSetMethodInfoInterfaceAction), "setMethodInfoInterface")]
    [JsonSubtypes.KnownSubType(typeof(PaymentSetMethodInfoMethodAction), "setMethodInfoMethod")]
    [JsonSubtypes.KnownSubType(typeof(PaymentSetMethodInfoNameAction), "setMethodInfoName")]
    [JsonSubtypes.KnownSubType(typeof(PaymentSetStatusInterfaceCodeAction), "setStatusInterfaceCode")]
    [JsonSubtypes.KnownSubType(typeof(PaymentSetStatusInterfaceTextAction), "setStatusInterfaceText")]
    [JsonSubtypes.KnownSubType(typeof(PaymentTransitionStateAction), "transitionState")]
    public abstract class PaymentUpdateAction 
    {
        public string Action { get; set;}
    }
}
