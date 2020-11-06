using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [TypeDiscriminator(nameof(Action))]
    [SubTypeDiscriminator("addCustomLineItem", typeof(commercetools.Api.Models.Carts.CartAddCustomLineItemAction))]
    [SubTypeDiscriminator("addDiscountCode", typeof(commercetools.Api.Models.Carts.CartAddDiscountCodeAction))]
    [SubTypeDiscriminator("addItemShippingAddress", typeof(commercetools.Api.Models.Carts.CartAddItemShippingAddressAction))]
    [SubTypeDiscriminator("addLineItem", typeof(commercetools.Api.Models.Carts.CartAddLineItemAction))]
    [SubTypeDiscriminator("addPayment", typeof(commercetools.Api.Models.Carts.CartAddPaymentAction))]
    [SubTypeDiscriminator("addShoppingList", typeof(commercetools.Api.Models.Carts.CartAddShoppingListAction))]
    [SubTypeDiscriminator("applyDeltaToCustomLineItemShippingDetailsTargets", typeof(commercetools.Api.Models.Carts.CartApplyDeltaToCustomLineItemShippingDetailsTargetsAction))]
    [SubTypeDiscriminator("applyDeltaToLineItemShippingDetailsTargets", typeof(commercetools.Api.Models.Carts.CartApplyDeltaToLineItemShippingDetailsTargetsAction))]
    [SubTypeDiscriminator("changeCustomLineItemMoney", typeof(commercetools.Api.Models.Carts.CartChangeCustomLineItemMoneyAction))]
    [SubTypeDiscriminator("changeCustomLineItemQuantity", typeof(commercetools.Api.Models.Carts.CartChangeCustomLineItemQuantityAction))]
    [SubTypeDiscriminator("changeLineItemQuantity", typeof(commercetools.Api.Models.Carts.CartChangeLineItemQuantityAction))]
    [SubTypeDiscriminator("changeTaxCalculationMode", typeof(commercetools.Api.Models.Carts.CartChangeTaxCalculationModeAction))]
    [SubTypeDiscriminator("changeTaxMode", typeof(commercetools.Api.Models.Carts.CartChangeTaxModeAction))]
    [SubTypeDiscriminator("changeTaxRoundingMode", typeof(commercetools.Api.Models.Carts.CartChangeTaxRoundingModeAction))]
    [SubTypeDiscriminator("recalculate", typeof(commercetools.Api.Models.Carts.CartRecalculateAction))]
    [SubTypeDiscriminator("removeCustomLineItem", typeof(commercetools.Api.Models.Carts.CartRemoveCustomLineItemAction))]
    [SubTypeDiscriminator("removeDiscountCode", typeof(commercetools.Api.Models.Carts.CartRemoveDiscountCodeAction))]
    [SubTypeDiscriminator("removeItemShippingAddress", typeof(commercetools.Api.Models.Carts.CartRemoveItemShippingAddressAction))]
    [SubTypeDiscriminator("removeLineItem", typeof(commercetools.Api.Models.Carts.CartRemoveLineItemAction))]
    [SubTypeDiscriminator("removePayment", typeof(commercetools.Api.Models.Carts.CartRemovePaymentAction))]
    [SubTypeDiscriminator("setAnonymousId", typeof(commercetools.Api.Models.Carts.CartSetAnonymousIdAction))]
    [SubTypeDiscriminator("setBillingAddress", typeof(commercetools.Api.Models.Carts.CartSetBillingAddressAction))]
    [SubTypeDiscriminator("setCartTotalTax", typeof(commercetools.Api.Models.Carts.CartSetCartTotalTaxAction))]
    [SubTypeDiscriminator("setCountry", typeof(commercetools.Api.Models.Carts.CartSetCountryAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Api.Models.Carts.CartSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomLineItemCustomField", typeof(commercetools.Api.Models.Carts.CartSetCustomLineItemCustomFieldAction))]
    [SubTypeDiscriminator("setCustomLineItemCustomType", typeof(commercetools.Api.Models.Carts.CartSetCustomLineItemCustomTypeAction))]
    [SubTypeDiscriminator("setCustomLineItemShippingDetails", typeof(commercetools.Api.Models.Carts.CartSetCustomLineItemShippingDetailsAction))]
    [SubTypeDiscriminator("setCustomLineItemTaxAmount", typeof(commercetools.Api.Models.Carts.CartSetCustomLineItemTaxAmountAction))]
    [SubTypeDiscriminator("setCustomLineItemTaxRate", typeof(commercetools.Api.Models.Carts.CartSetCustomLineItemTaxRateAction))]
    [SubTypeDiscriminator("setCustomShippingMethod", typeof(commercetools.Api.Models.Carts.CartSetCustomShippingMethodAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Api.Models.Carts.CartSetCustomTypeAction))]
    [SubTypeDiscriminator("setCustomerEmail", typeof(commercetools.Api.Models.Carts.CartSetCustomerEmailAction))]
    [SubTypeDiscriminator("setCustomerGroup", typeof(commercetools.Api.Models.Carts.CartSetCustomerGroupAction))]
    [SubTypeDiscriminator("setCustomerId", typeof(commercetools.Api.Models.Carts.CartSetCustomerIdAction))]
    [SubTypeDiscriminator("setDeleteDaysAfterLastModification", typeof(commercetools.Api.Models.Carts.CartSetDeleteDaysAfterLastModificationAction))]
    [SubTypeDiscriminator("setLineItemCustomField", typeof(commercetools.Api.Models.Carts.CartSetLineItemCustomFieldAction))]
    [SubTypeDiscriminator("setLineItemCustomType", typeof(commercetools.Api.Models.Carts.CartSetLineItemCustomTypeAction))]
    [SubTypeDiscriminator("setLineItemDistributionChannel", typeof(commercetools.Api.Models.Carts.CartSetLineItemDistributionChannelAction))]
    [SubTypeDiscriminator("setLineItemPrice", typeof(commercetools.Api.Models.Carts.CartSetLineItemPriceAction))]
    [SubTypeDiscriminator("setLineItemShippingDetails", typeof(commercetools.Api.Models.Carts.CartSetLineItemShippingDetailsAction))]
    [SubTypeDiscriminator("setLineItemTaxAmount", typeof(commercetools.Api.Models.Carts.CartSetLineItemTaxAmountAction))]
    [SubTypeDiscriminator("setLineItemTaxRate", typeof(commercetools.Api.Models.Carts.CartSetLineItemTaxRateAction))]
    [SubTypeDiscriminator("setLineItemTotalPrice", typeof(commercetools.Api.Models.Carts.CartSetLineItemTotalPriceAction))]
    [SubTypeDiscriminator("setLocale", typeof(commercetools.Api.Models.Carts.CartSetLocaleAction))]
    [SubTypeDiscriminator("setShippingAddress", typeof(commercetools.Api.Models.Carts.CartSetShippingAddressAction))]
    [SubTypeDiscriminator("setShippingMethod", typeof(commercetools.Api.Models.Carts.CartSetShippingMethodAction))]
    [SubTypeDiscriminator("setShippingMethodTaxAmount", typeof(commercetools.Api.Models.Carts.CartSetShippingMethodTaxAmountAction))]
    [SubTypeDiscriminator("setShippingMethodTaxRate", typeof(commercetools.Api.Models.Carts.CartSetShippingMethodTaxRateAction))]
    [SubTypeDiscriminator("setShippingRateInput", typeof(commercetools.Api.Models.Carts.CartSetShippingRateInputAction))]
    [SubTypeDiscriminator("updateItemShippingAddress", typeof(commercetools.Api.Models.Carts.CartUpdateItemShippingAddressAction))]
    public partial interface ICartUpdateAction 
    {
        string Action { get; set;}
    }
}
