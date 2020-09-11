using commercetools.Api.Models.Me;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Me
{
    [JsonConverter(typeof(JsonSubtypes), "action")]
    [JsonSubtypes.KnownSubType(typeof(MyCartAddDiscountCodeAction), "addDiscountCode")]
    [JsonSubtypes.KnownSubType(typeof(MyCartAddItemShippingAddressAction), "addItemShippingAddress")]
    [JsonSubtypes.KnownSubType(typeof(MyCartAddLineItemAction), "addLineItem")]
    [JsonSubtypes.KnownSubType(typeof(MyCartAddPaymentAction), "addPayment")]
    [JsonSubtypes.KnownSubType(typeof(MyCartApplyDeltaToLineItemShippingDetailsTargetsAction), "applyDeltaToLineItemShippingDetailsTargets")]
    [JsonSubtypes.KnownSubType(typeof(MyCartChangeLineItemQuantityAction), "changeLineItemQuantity")]
    [JsonSubtypes.KnownSubType(typeof(MyCartChangeTaxModeAction), "changeTaxMode")]
    [JsonSubtypes.KnownSubType(typeof(MyCartRecalculateAction), "recalculate")]
    [JsonSubtypes.KnownSubType(typeof(MyCartRemoveDiscountCodeAction), "removeDiscountCode")]
    [JsonSubtypes.KnownSubType(typeof(MyCartRemoveItemShippingAddressAction), "removeItemShippingAddress")]
    [JsonSubtypes.KnownSubType(typeof(MyCartRemoveLineItemAction), "removeLineItem")]
    [JsonSubtypes.KnownSubType(typeof(MyCartRemovePaymentAction), "removePayment")]
    [JsonSubtypes.KnownSubType(typeof(MyCartSetBillingAddressAction), "setBillingAddress")]
    [JsonSubtypes.KnownSubType(typeof(MyCartSetCountryAction), "setCountry")]
    [JsonSubtypes.KnownSubType(typeof(MyCartSetCustomFieldAction), "setCustomField")]
    [JsonSubtypes.KnownSubType(typeof(MyCartSetCustomShippingMethodAction), "setCustomShippingMethod")]
    [JsonSubtypes.KnownSubType(typeof(MyCartSetCustomTypeAction), "setCustomType")]
    [JsonSubtypes.KnownSubType(typeof(MyCartSetDeleteDaysAfterLastModificationAction), "setDeleteDaysAfterLastModification")]
    [JsonSubtypes.KnownSubType(typeof(MyCartSetLineItemCustomFieldAction), "setLineItemCustomField")]
    [JsonSubtypes.KnownSubType(typeof(MyCartSetLineItemCustomTypeAction), "setLineItemCustomType")]
    [JsonSubtypes.KnownSubType(typeof(MyCartSetLineItemShippingDetailsAction), "setLineItemShippingDetails")]
    [JsonSubtypes.KnownSubType(typeof(MyCartSetLocaleAction), "setLocale")]
    [JsonSubtypes.KnownSubType(typeof(MyCartSetShippingAddressAction), "setShippingAddress")]
    [JsonSubtypes.KnownSubType(typeof(MyCartSetShippingMethodAction), "setShippingMethod")]
    [JsonSubtypes.KnownSubType(typeof(MyCartUpdateItemShippingAddressAction), "updateItemShippingAddress")]
    public abstract class MyCartUpdateAction 
    {
        public string Action { get; set;}
    }
}
