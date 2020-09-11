using commercetools.Api.Models.Me;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Me
{
    [JsonConverter(typeof(JsonSubtypes), "action")]
    [JsonSubtypes.KnownSubType(typeof(MyPaymentAddTransactionAction), "addTransaction")]
    [JsonSubtypes.KnownSubType(typeof(MyPaymentChangeAmountPlannedAction), "changeAmountPlanned")]
    [JsonSubtypes.KnownSubType(typeof(MyPaymentSetCustomFieldAction), "setCustomField")]
    [JsonSubtypes.KnownSubType(typeof(MyPaymentSetMethodInfoInterfaceAction), "setMethodInfoInterface")]
    [JsonSubtypes.KnownSubType(typeof(MyPaymentSetMethodInfoMethodAction), "setMethodInfoMethod")]
    [JsonSubtypes.KnownSubType(typeof(MyPaymentSetMethodInfoNameAction), "setMethodInfoName")]
    public abstract class MyPaymentUpdateAction 
    {
        public string Action { get; set;}
    }
}
