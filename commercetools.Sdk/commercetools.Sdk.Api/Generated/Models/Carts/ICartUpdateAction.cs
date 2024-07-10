using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Carts.CartUpdateAction))]
    [SubTypeDiscriminator("addCustomLineItem", typeof(commercetools.Sdk.Api.Models.Carts.CartAddCustomLineItemAction))]
    [SubTypeDiscriminator("addCustomShippingMethod", typeof(commercetools.Sdk.Api.Models.Carts.CartAddCustomShippingMethodAction))]
    [SubTypeDiscriminator("addDiscountCode", typeof(commercetools.Sdk.Api.Models.Carts.CartAddDiscountCodeAction))]
    [SubTypeDiscriminator("addItemShippingAddress", typeof(commercetools.Sdk.Api.Models.Carts.CartAddItemShippingAddressAction))]
    [SubTypeDiscriminator("addLineItem", typeof(commercetools.Sdk.Api.Models.Carts.CartAddLineItemAction))]
    [SubTypeDiscriminator("addPayment", typeof(commercetools.Sdk.Api.Models.Carts.CartAddPaymentAction))]
    [SubTypeDiscriminator("addShippingMethod", typeof(commercetools.Sdk.Api.Models.Carts.CartAddShippingMethodAction))]
    [SubTypeDiscriminator("addShoppingList", typeof(commercetools.Sdk.Api.Models.Carts.CartAddShoppingListAction))]
    [SubTypeDiscriminator("applyDeltaToCustomLineItemShippingDetailsTargets", typeof(commercetools.Sdk.Api.Models.Carts.CartApplyDeltaToCustomLineItemShippingDetailsTargetsAction))]
    [SubTypeDiscriminator("applyDeltaToLineItemShippingDetailsTargets", typeof(commercetools.Sdk.Api.Models.Carts.CartApplyDeltaToLineItemShippingDetailsTargetsAction))]
    [SubTypeDiscriminator("changeCustomLineItemMoney", typeof(commercetools.Sdk.Api.Models.Carts.CartChangeCustomLineItemMoneyAction))]
    [SubTypeDiscriminator("changeCustomLineItemPriceMode", typeof(commercetools.Sdk.Api.Models.Carts.CartChangeCustomLineItemPriceModeAction))]
    [SubTypeDiscriminator("changeCustomLineItemQuantity", typeof(commercetools.Sdk.Api.Models.Carts.CartChangeCustomLineItemQuantityAction))]
    [SubTypeDiscriminator("changeLineItemQuantity", typeof(commercetools.Sdk.Api.Models.Carts.CartChangeLineItemQuantityAction))]
    [SubTypeDiscriminator("changeTaxCalculationMode", typeof(commercetools.Sdk.Api.Models.Carts.CartChangeTaxCalculationModeAction))]
    [SubTypeDiscriminator("changeTaxMode", typeof(commercetools.Sdk.Api.Models.Carts.CartChangeTaxModeAction))]
    [SubTypeDiscriminator("changeTaxRoundingMode", typeof(commercetools.Sdk.Api.Models.Carts.CartChangeTaxRoundingModeAction))]
    [SubTypeDiscriminator("freezeCart", typeof(commercetools.Sdk.Api.Models.Carts.CartFreezeCartAction))]
    [SubTypeDiscriminator("recalculate", typeof(commercetools.Sdk.Api.Models.Carts.CartRecalculateAction))]
    [SubTypeDiscriminator("removeCustomLineItem", typeof(commercetools.Sdk.Api.Models.Carts.CartRemoveCustomLineItemAction))]
    [SubTypeDiscriminator("removeDiscountCode", typeof(commercetools.Sdk.Api.Models.Carts.CartRemoveDiscountCodeAction))]
    [SubTypeDiscriminator("removeItemShippingAddress", typeof(commercetools.Sdk.Api.Models.Carts.CartRemoveItemShippingAddressAction))]
    [SubTypeDiscriminator("removeLineItem", typeof(commercetools.Sdk.Api.Models.Carts.CartRemoveLineItemAction))]
    [SubTypeDiscriminator("removePayment", typeof(commercetools.Sdk.Api.Models.Carts.CartRemovePaymentAction))]
    [SubTypeDiscriminator("removeShippingMethod", typeof(commercetools.Sdk.Api.Models.Carts.CartRemoveShippingMethodAction))]
    [SubTypeDiscriminator("setAnonymousId", typeof(commercetools.Sdk.Api.Models.Carts.CartSetAnonymousIdAction))]
    [SubTypeDiscriminator("setBillingAddress", typeof(commercetools.Sdk.Api.Models.Carts.CartSetBillingAddressAction))]
    [SubTypeDiscriminator("setBillingAddressCustomField", typeof(commercetools.Sdk.Api.Models.Carts.CartSetBillingAddressCustomFieldAction))]
    [SubTypeDiscriminator("setBillingAddressCustomType", typeof(commercetools.Sdk.Api.Models.Carts.CartSetBillingAddressCustomTypeAction))]
    [SubTypeDiscriminator("setBusinessUnit", typeof(commercetools.Sdk.Api.Models.Carts.CartSetBusinessUnitAction))]
    [SubTypeDiscriminator("setCartTotalTax", typeof(commercetools.Sdk.Api.Models.Carts.CartSetCartTotalTaxAction))]
    [SubTypeDiscriminator("setCountry", typeof(commercetools.Sdk.Api.Models.Carts.CartSetCountryAction))]
    [SubTypeDiscriminator("setCustomerEmail", typeof(commercetools.Sdk.Api.Models.Carts.CartSetCustomerEmailAction))]
    [SubTypeDiscriminator("setCustomerGroup", typeof(commercetools.Sdk.Api.Models.Carts.CartSetCustomerGroupAction))]
    [SubTypeDiscriminator("setCustomerId", typeof(commercetools.Sdk.Api.Models.Carts.CartSetCustomerIdAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Sdk.Api.Models.Carts.CartSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomLineItemCustomField", typeof(commercetools.Sdk.Api.Models.Carts.CartSetCustomLineItemCustomFieldAction))]
    [SubTypeDiscriminator("setCustomLineItemCustomType", typeof(commercetools.Sdk.Api.Models.Carts.CartSetCustomLineItemCustomTypeAction))]
    [SubTypeDiscriminator("setCustomLineItemShippingDetails", typeof(commercetools.Sdk.Api.Models.Carts.CartSetCustomLineItemShippingDetailsAction))]
    [SubTypeDiscriminator("setCustomLineItemTaxAmount", typeof(commercetools.Sdk.Api.Models.Carts.CartSetCustomLineItemTaxAmountAction))]
    [SubTypeDiscriminator("setCustomLineItemTaxRate", typeof(commercetools.Sdk.Api.Models.Carts.CartSetCustomLineItemTaxRateAction))]
    [SubTypeDiscriminator("setCustomShippingMethod", typeof(commercetools.Sdk.Api.Models.Carts.CartSetCustomShippingMethodAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Sdk.Api.Models.Carts.CartSetCustomTypeAction))]
    [SubTypeDiscriminator("setDeleteDaysAfterLastModification", typeof(commercetools.Sdk.Api.Models.Carts.CartSetDeleteDaysAfterLastModificationAction))]
    [SubTypeDiscriminator("setDirectDiscounts", typeof(commercetools.Sdk.Api.Models.Carts.CartSetDirectDiscountsAction))]
    [SubTypeDiscriminator("setItemShippingAddressCustomField", typeof(commercetools.Sdk.Api.Models.Carts.CartSetItemShippingAddressCustomFieldAction))]
    [SubTypeDiscriminator("setItemShippingAddressCustomType", typeof(commercetools.Sdk.Api.Models.Carts.CartSetItemShippingAddressCustomTypeAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Sdk.Api.Models.Carts.CartSetKeyAction))]
    [SubTypeDiscriminator("setLineItemCustomField", typeof(commercetools.Sdk.Api.Models.Carts.CartSetLineItemCustomFieldAction))]
    [SubTypeDiscriminator("setLineItemCustomType", typeof(commercetools.Sdk.Api.Models.Carts.CartSetLineItemCustomTypeAction))]
    [SubTypeDiscriminator("setLineItemDistributionChannel", typeof(commercetools.Sdk.Api.Models.Carts.CartSetLineItemDistributionChannelAction))]
    [SubTypeDiscriminator("setLineItemInventoryMode", typeof(commercetools.Sdk.Api.Models.Carts.CartSetLineItemInventoryModeAction))]
    [SubTypeDiscriminator("setLineItemPrice", typeof(commercetools.Sdk.Api.Models.Carts.CartSetLineItemPriceAction))]
    [SubTypeDiscriminator("setLineItemShippingDetails", typeof(commercetools.Sdk.Api.Models.Carts.CartSetLineItemShippingDetailsAction))]
    [SubTypeDiscriminator("setLineItemSupplyChannel", typeof(commercetools.Sdk.Api.Models.Carts.CartSetLineItemSupplyChannelAction))]
    [SubTypeDiscriminator("setLineItemTaxAmount", typeof(commercetools.Sdk.Api.Models.Carts.CartSetLineItemTaxAmountAction))]
    [SubTypeDiscriminator("setLineItemTaxRate", typeof(commercetools.Sdk.Api.Models.Carts.CartSetLineItemTaxRateAction))]
    [SubTypeDiscriminator("setLineItemTotalPrice", typeof(commercetools.Sdk.Api.Models.Carts.CartSetLineItemTotalPriceAction))]
    [SubTypeDiscriminator("setLocale", typeof(commercetools.Sdk.Api.Models.Carts.CartSetLocaleAction))]
    [SubTypeDiscriminator("setShippingAddress", typeof(commercetools.Sdk.Api.Models.Carts.CartSetShippingAddressAction))]
    [SubTypeDiscriminator("setShippingAddressCustomField", typeof(commercetools.Sdk.Api.Models.Carts.CartSetShippingAddressCustomFieldAction))]
    [SubTypeDiscriminator("setShippingAddressCustomType", typeof(commercetools.Sdk.Api.Models.Carts.CartSetShippingAddressCustomTypeAction))]
    [SubTypeDiscriminator("setShippingCustomField", typeof(commercetools.Sdk.Api.Models.Carts.CartSetShippingCustomFieldAction))]
    [SubTypeDiscriminator("setShippingCustomType", typeof(commercetools.Sdk.Api.Models.Carts.CartSetShippingCustomTypeAction))]
    [SubTypeDiscriminator("setShippingMethod", typeof(commercetools.Sdk.Api.Models.Carts.CartSetShippingMethodAction))]
    [SubTypeDiscriminator("setShippingMethodTaxAmount", typeof(commercetools.Sdk.Api.Models.Carts.CartSetShippingMethodTaxAmountAction))]
    [SubTypeDiscriminator("setShippingMethodTaxRate", typeof(commercetools.Sdk.Api.Models.Carts.CartSetShippingMethodTaxRateAction))]
    [SubTypeDiscriminator("setShippingRateInput", typeof(commercetools.Sdk.Api.Models.Carts.CartSetShippingRateInputAction))]
    [SubTypeDiscriminator("unfreezeCart", typeof(commercetools.Sdk.Api.Models.Carts.CartUnfreezeCartAction))]
    [SubTypeDiscriminator("updateItemShippingAddress", typeof(commercetools.Sdk.Api.Models.Carts.CartUpdateItemShippingAddressAction))]
    public partial interface ICartUpdateAction
    {
        string Action { get; set; }

        static commercetools.Sdk.Api.Models.Carts.CartAddCustomLineItemAction AddCustomLineItem(Action<commercetools.Sdk.Api.Models.Carts.CartAddCustomLineItemAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartAddCustomLineItemAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartAddCustomShippingMethodAction AddCustomShippingMethod(Action<commercetools.Sdk.Api.Models.Carts.CartAddCustomShippingMethodAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartAddCustomShippingMethodAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartAddDiscountCodeAction AddDiscountCode(Action<commercetools.Sdk.Api.Models.Carts.CartAddDiscountCodeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartAddDiscountCodeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartAddItemShippingAddressAction AddItemShippingAddress(Action<commercetools.Sdk.Api.Models.Carts.CartAddItemShippingAddressAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartAddItemShippingAddressAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartAddLineItemAction AddLineItem(Action<commercetools.Sdk.Api.Models.Carts.CartAddLineItemAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartAddLineItemAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartAddPaymentAction AddPayment(Action<commercetools.Sdk.Api.Models.Carts.CartAddPaymentAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartAddPaymentAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartAddShippingMethodAction AddShippingMethod(Action<commercetools.Sdk.Api.Models.Carts.CartAddShippingMethodAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartAddShippingMethodAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartAddShoppingListAction AddShoppingList(Action<commercetools.Sdk.Api.Models.Carts.CartAddShoppingListAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartAddShoppingListAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartApplyDeltaToCustomLineItemShippingDetailsTargetsAction ApplyDeltaToCustomLineItemShippingDetailsTargets(Action<commercetools.Sdk.Api.Models.Carts.CartApplyDeltaToCustomLineItemShippingDetailsTargetsAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartApplyDeltaToCustomLineItemShippingDetailsTargetsAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartApplyDeltaToLineItemShippingDetailsTargetsAction ApplyDeltaToLineItemShippingDetailsTargets(Action<commercetools.Sdk.Api.Models.Carts.CartApplyDeltaToLineItemShippingDetailsTargetsAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartApplyDeltaToLineItemShippingDetailsTargetsAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartChangeCustomLineItemMoneyAction ChangeCustomLineItemMoney(Action<commercetools.Sdk.Api.Models.Carts.CartChangeCustomLineItemMoneyAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartChangeCustomLineItemMoneyAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartChangeCustomLineItemPriceModeAction ChangeCustomLineItemPriceMode(Action<commercetools.Sdk.Api.Models.Carts.CartChangeCustomLineItemPriceModeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartChangeCustomLineItemPriceModeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartChangeCustomLineItemQuantityAction ChangeCustomLineItemQuantity(Action<commercetools.Sdk.Api.Models.Carts.CartChangeCustomLineItemQuantityAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartChangeCustomLineItemQuantityAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartChangeLineItemQuantityAction ChangeLineItemQuantity(Action<commercetools.Sdk.Api.Models.Carts.CartChangeLineItemQuantityAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartChangeLineItemQuantityAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartChangeTaxCalculationModeAction ChangeTaxCalculationMode(Action<commercetools.Sdk.Api.Models.Carts.CartChangeTaxCalculationModeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartChangeTaxCalculationModeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartChangeTaxModeAction ChangeTaxMode(Action<commercetools.Sdk.Api.Models.Carts.CartChangeTaxModeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartChangeTaxModeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartChangeTaxRoundingModeAction ChangeTaxRoundingMode(Action<commercetools.Sdk.Api.Models.Carts.CartChangeTaxRoundingModeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartChangeTaxRoundingModeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartFreezeCartAction FreezeCart(Action<commercetools.Sdk.Api.Models.Carts.CartFreezeCartAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartFreezeCartAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartRecalculateAction Recalculate(Action<commercetools.Sdk.Api.Models.Carts.CartRecalculateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartRecalculateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartRemoveCustomLineItemAction RemoveCustomLineItem(Action<commercetools.Sdk.Api.Models.Carts.CartRemoveCustomLineItemAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartRemoveCustomLineItemAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartRemoveDiscountCodeAction RemoveDiscountCode(Action<commercetools.Sdk.Api.Models.Carts.CartRemoveDiscountCodeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartRemoveDiscountCodeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartRemoveItemShippingAddressAction RemoveItemShippingAddress(Action<commercetools.Sdk.Api.Models.Carts.CartRemoveItemShippingAddressAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartRemoveItemShippingAddressAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartRemoveLineItemAction RemoveLineItem(Action<commercetools.Sdk.Api.Models.Carts.CartRemoveLineItemAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartRemoveLineItemAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartRemovePaymentAction RemovePayment(Action<commercetools.Sdk.Api.Models.Carts.CartRemovePaymentAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartRemovePaymentAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartRemoveShippingMethodAction RemoveShippingMethod(Action<commercetools.Sdk.Api.Models.Carts.CartRemoveShippingMethodAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartRemoveShippingMethodAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartSetAnonymousIdAction SetAnonymousId(Action<commercetools.Sdk.Api.Models.Carts.CartSetAnonymousIdAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartSetAnonymousIdAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartSetBillingAddressAction SetBillingAddress(Action<commercetools.Sdk.Api.Models.Carts.CartSetBillingAddressAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartSetBillingAddressAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartSetBillingAddressCustomFieldAction SetBillingAddressCustomField(Action<commercetools.Sdk.Api.Models.Carts.CartSetBillingAddressCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartSetBillingAddressCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartSetBillingAddressCustomTypeAction SetBillingAddressCustomType(Action<commercetools.Sdk.Api.Models.Carts.CartSetBillingAddressCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartSetBillingAddressCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartSetBusinessUnitAction SetBusinessUnit(Action<commercetools.Sdk.Api.Models.Carts.CartSetBusinessUnitAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartSetBusinessUnitAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartSetCartTotalTaxAction SetCartTotalTax(Action<commercetools.Sdk.Api.Models.Carts.CartSetCartTotalTaxAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartSetCartTotalTaxAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartSetCountryAction SetCountry(Action<commercetools.Sdk.Api.Models.Carts.CartSetCountryAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartSetCountryAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartSetCustomerEmailAction SetCustomerEmail(Action<commercetools.Sdk.Api.Models.Carts.CartSetCustomerEmailAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartSetCustomerEmailAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartSetCustomerGroupAction SetCustomerGroup(Action<commercetools.Sdk.Api.Models.Carts.CartSetCustomerGroupAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartSetCustomerGroupAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartSetCustomerIdAction SetCustomerId(Action<commercetools.Sdk.Api.Models.Carts.CartSetCustomerIdAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartSetCustomerIdAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartSetCustomFieldAction SetCustomField(Action<commercetools.Sdk.Api.Models.Carts.CartSetCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartSetCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartSetCustomLineItemCustomFieldAction SetCustomLineItemCustomField(Action<commercetools.Sdk.Api.Models.Carts.CartSetCustomLineItemCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartSetCustomLineItemCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartSetCustomLineItemCustomTypeAction SetCustomLineItemCustomType(Action<commercetools.Sdk.Api.Models.Carts.CartSetCustomLineItemCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartSetCustomLineItemCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartSetCustomLineItemShippingDetailsAction SetCustomLineItemShippingDetails(Action<commercetools.Sdk.Api.Models.Carts.CartSetCustomLineItemShippingDetailsAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartSetCustomLineItemShippingDetailsAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartSetCustomLineItemTaxAmountAction SetCustomLineItemTaxAmount(Action<commercetools.Sdk.Api.Models.Carts.CartSetCustomLineItemTaxAmountAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartSetCustomLineItemTaxAmountAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartSetCustomLineItemTaxRateAction SetCustomLineItemTaxRate(Action<commercetools.Sdk.Api.Models.Carts.CartSetCustomLineItemTaxRateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartSetCustomLineItemTaxRateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartSetCustomShippingMethodAction SetCustomShippingMethod(Action<commercetools.Sdk.Api.Models.Carts.CartSetCustomShippingMethodAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartSetCustomShippingMethodAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartSetCustomTypeAction SetCustomType(Action<commercetools.Sdk.Api.Models.Carts.CartSetCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartSetCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartSetDeleteDaysAfterLastModificationAction SetDeleteDaysAfterLastModification(Action<commercetools.Sdk.Api.Models.Carts.CartSetDeleteDaysAfterLastModificationAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartSetDeleteDaysAfterLastModificationAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartSetDirectDiscountsAction SetDirectDiscounts(Action<commercetools.Sdk.Api.Models.Carts.CartSetDirectDiscountsAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartSetDirectDiscountsAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartSetItemShippingAddressCustomFieldAction SetItemShippingAddressCustomField(Action<commercetools.Sdk.Api.Models.Carts.CartSetItemShippingAddressCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartSetItemShippingAddressCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartSetItemShippingAddressCustomTypeAction SetItemShippingAddressCustomType(Action<commercetools.Sdk.Api.Models.Carts.CartSetItemShippingAddressCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartSetItemShippingAddressCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartSetKeyAction SetKey(Action<commercetools.Sdk.Api.Models.Carts.CartSetKeyAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartSetKeyAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartSetLineItemCustomFieldAction SetLineItemCustomField(Action<commercetools.Sdk.Api.Models.Carts.CartSetLineItemCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartSetLineItemCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartSetLineItemCustomTypeAction SetLineItemCustomType(Action<commercetools.Sdk.Api.Models.Carts.CartSetLineItemCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartSetLineItemCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartSetLineItemDistributionChannelAction SetLineItemDistributionChannel(Action<commercetools.Sdk.Api.Models.Carts.CartSetLineItemDistributionChannelAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartSetLineItemDistributionChannelAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartSetLineItemInventoryModeAction SetLineItemInventoryMode(Action<commercetools.Sdk.Api.Models.Carts.CartSetLineItemInventoryModeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartSetLineItemInventoryModeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartSetLineItemPriceAction SetLineItemPrice(Action<commercetools.Sdk.Api.Models.Carts.CartSetLineItemPriceAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartSetLineItemPriceAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartSetLineItemShippingDetailsAction SetLineItemShippingDetails(Action<commercetools.Sdk.Api.Models.Carts.CartSetLineItemShippingDetailsAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartSetLineItemShippingDetailsAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartSetLineItemSupplyChannelAction SetLineItemSupplyChannel(Action<commercetools.Sdk.Api.Models.Carts.CartSetLineItemSupplyChannelAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartSetLineItemSupplyChannelAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartSetLineItemTaxAmountAction SetLineItemTaxAmount(Action<commercetools.Sdk.Api.Models.Carts.CartSetLineItemTaxAmountAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartSetLineItemTaxAmountAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartSetLineItemTaxRateAction SetLineItemTaxRate(Action<commercetools.Sdk.Api.Models.Carts.CartSetLineItemTaxRateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartSetLineItemTaxRateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartSetLineItemTotalPriceAction SetLineItemTotalPrice(Action<commercetools.Sdk.Api.Models.Carts.CartSetLineItemTotalPriceAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartSetLineItemTotalPriceAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartSetLocaleAction SetLocale(Action<commercetools.Sdk.Api.Models.Carts.CartSetLocaleAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartSetLocaleAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartSetShippingAddressAction SetShippingAddress(Action<commercetools.Sdk.Api.Models.Carts.CartSetShippingAddressAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartSetShippingAddressAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartSetShippingAddressCustomFieldAction SetShippingAddressCustomField(Action<commercetools.Sdk.Api.Models.Carts.CartSetShippingAddressCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartSetShippingAddressCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartSetShippingAddressCustomTypeAction SetShippingAddressCustomType(Action<commercetools.Sdk.Api.Models.Carts.CartSetShippingAddressCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartSetShippingAddressCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartSetShippingCustomFieldAction SetShippingCustomField(Action<commercetools.Sdk.Api.Models.Carts.CartSetShippingCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartSetShippingCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartSetShippingCustomTypeAction SetShippingCustomType(Action<commercetools.Sdk.Api.Models.Carts.CartSetShippingCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartSetShippingCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartSetShippingMethodAction SetShippingMethod(Action<commercetools.Sdk.Api.Models.Carts.CartSetShippingMethodAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartSetShippingMethodAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartSetShippingMethodTaxAmountAction SetShippingMethodTaxAmount(Action<commercetools.Sdk.Api.Models.Carts.CartSetShippingMethodTaxAmountAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartSetShippingMethodTaxAmountAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartSetShippingMethodTaxRateAction SetShippingMethodTaxRate(Action<commercetools.Sdk.Api.Models.Carts.CartSetShippingMethodTaxRateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartSetShippingMethodTaxRateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartSetShippingRateInputAction SetShippingRateInput(Action<commercetools.Sdk.Api.Models.Carts.CartSetShippingRateInputAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartSetShippingRateInputAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartUnfreezeCartAction UnfreezeCart(Action<commercetools.Sdk.Api.Models.Carts.CartUnfreezeCartAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartUnfreezeCartAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartUpdateItemShippingAddressAction UpdateItemShippingAddress(Action<commercetools.Sdk.Api.Models.Carts.CartUpdateItemShippingAddressAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartUpdateItemShippingAddressAction();
            init?.Invoke(t);
            return t;
        }
    }
}
