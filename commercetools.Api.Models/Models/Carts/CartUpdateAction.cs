using commercetools.Api.Models.Carts;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Carts
{
    [JsonConverter(typeof(JsonSubtypes), "action")]
    [JsonSubtypes.KnownSubType(typeof(CartAddCustomLineItemAction), "addCustomLineItem")]
    [JsonSubtypes.KnownSubType(typeof(CartAddDiscountCodeAction), "addDiscountCode")]
    [JsonSubtypes.KnownSubType(typeof(CartAddItemShippingAddressAction), "addItemShippingAddress")]
    [JsonSubtypes.KnownSubType(typeof(CartAddLineItemAction), "addLineItem")]
    [JsonSubtypes.KnownSubType(typeof(CartAddPaymentAction), "addPayment")]
    [JsonSubtypes.KnownSubType(typeof(CartAddShoppingListAction), "addShoppingList")]
    [JsonSubtypes.KnownSubType(typeof(CartApplyDeltaToCustomLineItemShippingDetailsTargetsAction), "applyDeltaToCustomLineItemShippingDetailsTargets")]
    [JsonSubtypes.KnownSubType(typeof(CartApplyDeltaToLineItemShippingDetailsTargetsAction), "applyDeltaToLineItemShippingDetailsTargets")]
    [JsonSubtypes.KnownSubType(typeof(CartChangeCustomLineItemMoneyAction), "changeCustomLineItemMoney")]
    [JsonSubtypes.KnownSubType(typeof(CartChangeCustomLineItemQuantityAction), "changeCustomLineItemQuantity")]
    [JsonSubtypes.KnownSubType(typeof(CartChangeLineItemQuantityAction), "changeLineItemQuantity")]
    [JsonSubtypes.KnownSubType(typeof(CartChangeTaxCalculationModeAction), "changeTaxCalculationMode")]
    [JsonSubtypes.KnownSubType(typeof(CartChangeTaxModeAction), "changeTaxMode")]
    [JsonSubtypes.KnownSubType(typeof(CartChangeTaxRoundingModeAction), "changeTaxRoundingMode")]
    [JsonSubtypes.KnownSubType(typeof(CartRecalculateAction), "recalculate")]
    [JsonSubtypes.KnownSubType(typeof(CartRemoveCustomLineItemAction), "removeCustomLineItem")]
    [JsonSubtypes.KnownSubType(typeof(CartRemoveDiscountCodeAction), "removeDiscountCode")]
    [JsonSubtypes.KnownSubType(typeof(CartRemoveItemShippingAddressAction), "removeItemShippingAddress")]
    [JsonSubtypes.KnownSubType(typeof(CartRemoveLineItemAction), "removeLineItem")]
    [JsonSubtypes.KnownSubType(typeof(CartRemovePaymentAction), "removePayment")]
    [JsonSubtypes.KnownSubType(typeof(CartSetAnonymousIdAction), "setAnonymousId")]
    [JsonSubtypes.KnownSubType(typeof(CartSetBillingAddressAction), "setBillingAddress")]
    [JsonSubtypes.KnownSubType(typeof(CartSetCartTotalTaxAction), "setCartTotalTax")]
    [JsonSubtypes.KnownSubType(typeof(CartSetCountryAction), "setCountry")]
    [JsonSubtypes.KnownSubType(typeof(CartSetCustomFieldAction), "setCustomField")]
    [JsonSubtypes.KnownSubType(typeof(CartSetCustomLineItemCustomFieldAction), "setCustomLineItemCustomField")]
    [JsonSubtypes.KnownSubType(typeof(CartSetCustomLineItemCustomTypeAction), "setCustomLineItemCustomType")]
    [JsonSubtypes.KnownSubType(typeof(CartSetCustomLineItemShippingDetailsAction), "setCustomLineItemShippingDetails")]
    [JsonSubtypes.KnownSubType(typeof(CartSetCustomLineItemTaxAmountAction), "setCustomLineItemTaxAmount")]
    [JsonSubtypes.KnownSubType(typeof(CartSetCustomLineItemTaxRateAction), "setCustomLineItemTaxRate")]
    [JsonSubtypes.KnownSubType(typeof(CartSetCustomShippingMethodAction), "setCustomShippingMethod")]
    [JsonSubtypes.KnownSubType(typeof(CartSetCustomTypeAction), "setCustomType")]
    [JsonSubtypes.KnownSubType(typeof(CartSetCustomerEmailAction), "setCustomerEmail")]
    [JsonSubtypes.KnownSubType(typeof(CartSetCustomerGroupAction), "setCustomerGroup")]
    [JsonSubtypes.KnownSubType(typeof(CartSetCustomerIdAction), "setCustomerId")]
    [JsonSubtypes.KnownSubType(typeof(CartSetDeleteDaysAfterLastModificationAction), "setDeleteDaysAfterLastModification")]
    [JsonSubtypes.KnownSubType(typeof(CartSetLineItemCustomFieldAction), "setLineItemCustomField")]
    [JsonSubtypes.KnownSubType(typeof(CartSetLineItemCustomTypeAction), "setLineItemCustomType")]
    [JsonSubtypes.KnownSubType(typeof(CartSetLineItemPriceAction), "setLineItemPrice")]
    [JsonSubtypes.KnownSubType(typeof(CartSetLineItemShippingDetailsAction), "setLineItemShippingDetails")]
    [JsonSubtypes.KnownSubType(typeof(CartSetLineItemTaxAmountAction), "setLineItemTaxAmount")]
    [JsonSubtypes.KnownSubType(typeof(CartSetLineItemTaxRateAction), "setLineItemTaxRate")]
    [JsonSubtypes.KnownSubType(typeof(CartSetLineItemTotalPriceAction), "setLineItemTotalPrice")]
    [JsonSubtypes.KnownSubType(typeof(CartSetLocaleAction), "setLocale")]
    [JsonSubtypes.KnownSubType(typeof(CartSetShippingAddressAction), "setShippingAddress")]
    [JsonSubtypes.KnownSubType(typeof(CartSetShippingMethodAction), "setShippingMethod")]
    [JsonSubtypes.KnownSubType(typeof(CartSetShippingMethodTaxAmountAction), "setShippingMethodTaxAmount")]
    [JsonSubtypes.KnownSubType(typeof(CartSetShippingMethodTaxRateAction), "setShippingMethodTaxRate")]
    [JsonSubtypes.KnownSubType(typeof(CartSetShippingRateInputAction), "setShippingRateInput")]
    [JsonSubtypes.KnownSubType(typeof(CartUpdateItemShippingAddressAction), "updateItemShippingAddress")]
    public abstract class CartUpdateAction 
    {
        public string Action { get; set;}
    }
}
