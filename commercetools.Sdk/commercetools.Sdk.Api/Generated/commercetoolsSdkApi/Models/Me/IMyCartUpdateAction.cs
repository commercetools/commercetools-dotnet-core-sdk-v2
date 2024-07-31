using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Me.MyCartUpdateAction))]
    [SubTypeDiscriminator("addDiscountCode", typeof(commercetools.Sdk.Api.Models.Me.MyCartAddDiscountCodeAction))]
    [SubTypeDiscriminator("addItemShippingAddress", typeof(commercetools.Sdk.Api.Models.Me.MyCartAddItemShippingAddressAction))]
    [SubTypeDiscriminator("addLineItem", typeof(commercetools.Sdk.Api.Models.Me.MyCartAddLineItemAction))]
    [SubTypeDiscriminator("addPayment", typeof(commercetools.Sdk.Api.Models.Me.MyCartAddPaymentAction))]
    [SubTypeDiscriminator("applyDeltaToLineItemShippingDetailsTargets", typeof(commercetools.Sdk.Api.Models.Me.MyCartApplyDeltaToLineItemShippingDetailsTargetsAction))]
    [SubTypeDiscriminator("changeLineItemQuantity", typeof(commercetools.Sdk.Api.Models.Me.MyCartChangeLineItemQuantityAction))]
    [SubTypeDiscriminator("changeLineItemsOrder", typeof(commercetools.Sdk.Api.Models.Me.MyCartChangeLineItemsOrderAction))]
    [SubTypeDiscriminator("changeTaxMode", typeof(commercetools.Sdk.Api.Models.Me.MyCartChangeTaxModeAction))]
    [SubTypeDiscriminator("recalculate", typeof(commercetools.Sdk.Api.Models.Me.MyCartRecalculateAction))]
    [SubTypeDiscriminator("removeDiscountCode", typeof(commercetools.Sdk.Api.Models.Me.MyCartRemoveDiscountCodeAction))]
    [SubTypeDiscriminator("removeItemShippingAddress", typeof(commercetools.Sdk.Api.Models.Me.MyCartRemoveItemShippingAddressAction))]
    [SubTypeDiscriminator("removeLineItem", typeof(commercetools.Sdk.Api.Models.Me.MyCartRemoveLineItemAction))]
    [SubTypeDiscriminator("removePayment", typeof(commercetools.Sdk.Api.Models.Me.MyCartRemovePaymentAction))]
    [SubTypeDiscriminator("setBillingAddress", typeof(commercetools.Sdk.Api.Models.Me.MyCartSetBillingAddressAction))]
    [SubTypeDiscriminator("setBusinessUnit", typeof(commercetools.Sdk.Api.Models.Me.MyCartSetBusinessUnitAction))]
    [SubTypeDiscriminator("setCountry", typeof(commercetools.Sdk.Api.Models.Me.MyCartSetCountryAction))]
    [SubTypeDiscriminator("setCustomerEmail", typeof(commercetools.Sdk.Api.Models.Me.MyCartSetCustomerEmailAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Sdk.Api.Models.Me.MyCartSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Sdk.Api.Models.Me.MyCartSetCustomTypeAction))]
    [SubTypeDiscriminator("setDeleteDaysAfterLastModification", typeof(commercetools.Sdk.Api.Models.Me.MyCartSetDeleteDaysAfterLastModificationAction))]
    [SubTypeDiscriminator("setLineItemCustomField", typeof(commercetools.Sdk.Api.Models.Me.MyCartSetLineItemCustomFieldAction))]
    [SubTypeDiscriminator("setLineItemCustomType", typeof(commercetools.Sdk.Api.Models.Me.MyCartSetLineItemCustomTypeAction))]
    [SubTypeDiscriminator("setLineItemDistributionChannel", typeof(commercetools.Sdk.Api.Models.Me.MyCartSetLineItemDistributionChannelAction))]
    [SubTypeDiscriminator("setLineItemShippingDetails", typeof(commercetools.Sdk.Api.Models.Me.MyCartSetLineItemShippingDetailsAction))]
    [SubTypeDiscriminator("setLineItemSupplyChannel", typeof(commercetools.Sdk.Api.Models.Me.MyCartSetLineItemSupplyChannelAction))]
    [SubTypeDiscriminator("setLocale", typeof(commercetools.Sdk.Api.Models.Me.MyCartSetLocaleAction))]
    [SubTypeDiscriminator("setShippingAddress", typeof(commercetools.Sdk.Api.Models.Me.MyCartSetShippingAddressAction))]
    [SubTypeDiscriminator("setShippingMethod", typeof(commercetools.Sdk.Api.Models.Me.MyCartSetShippingMethodAction))]
    [SubTypeDiscriminator("updateItemShippingAddress", typeof(commercetools.Sdk.Api.Models.Me.MyCartUpdateItemShippingAddressAction))]
    public partial interface IMyCartUpdateAction
    {
        string Action { get; set; }

        static commercetools.Sdk.Api.Models.Me.MyCartAddDiscountCodeAction AddDiscountCode(Action<commercetools.Sdk.Api.Models.Me.MyCartAddDiscountCodeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCartAddDiscountCodeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyCartAddItemShippingAddressAction AddItemShippingAddress(Action<commercetools.Sdk.Api.Models.Me.MyCartAddItemShippingAddressAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCartAddItemShippingAddressAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyCartAddLineItemAction AddLineItem(Action<commercetools.Sdk.Api.Models.Me.MyCartAddLineItemAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCartAddLineItemAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyCartAddPaymentAction AddPayment(Action<commercetools.Sdk.Api.Models.Me.MyCartAddPaymentAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCartAddPaymentAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyCartApplyDeltaToLineItemShippingDetailsTargetsAction ApplyDeltaToLineItemShippingDetailsTargets(Action<commercetools.Sdk.Api.Models.Me.MyCartApplyDeltaToLineItemShippingDetailsTargetsAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCartApplyDeltaToLineItemShippingDetailsTargetsAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyCartChangeLineItemQuantityAction ChangeLineItemQuantity(Action<commercetools.Sdk.Api.Models.Me.MyCartChangeLineItemQuantityAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCartChangeLineItemQuantityAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyCartChangeLineItemsOrderAction ChangeLineItemsOrder(Action<commercetools.Sdk.Api.Models.Me.MyCartChangeLineItemsOrderAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCartChangeLineItemsOrderAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyCartChangeTaxModeAction ChangeTaxMode(Action<commercetools.Sdk.Api.Models.Me.MyCartChangeTaxModeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCartChangeTaxModeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyCartRecalculateAction Recalculate(Action<commercetools.Sdk.Api.Models.Me.MyCartRecalculateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCartRecalculateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyCartRemoveDiscountCodeAction RemoveDiscountCode(Action<commercetools.Sdk.Api.Models.Me.MyCartRemoveDiscountCodeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCartRemoveDiscountCodeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyCartRemoveItemShippingAddressAction RemoveItemShippingAddress(Action<commercetools.Sdk.Api.Models.Me.MyCartRemoveItemShippingAddressAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCartRemoveItemShippingAddressAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyCartRemoveLineItemAction RemoveLineItem(Action<commercetools.Sdk.Api.Models.Me.MyCartRemoveLineItemAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCartRemoveLineItemAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyCartRemovePaymentAction RemovePayment(Action<commercetools.Sdk.Api.Models.Me.MyCartRemovePaymentAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCartRemovePaymentAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyCartSetBillingAddressAction SetBillingAddress(Action<commercetools.Sdk.Api.Models.Me.MyCartSetBillingAddressAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCartSetBillingAddressAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyCartSetBusinessUnitAction SetBusinessUnit(Action<commercetools.Sdk.Api.Models.Me.MyCartSetBusinessUnitAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCartSetBusinessUnitAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyCartSetCountryAction SetCountry(Action<commercetools.Sdk.Api.Models.Me.MyCartSetCountryAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCartSetCountryAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyCartSetCustomerEmailAction SetCustomerEmail(Action<commercetools.Sdk.Api.Models.Me.MyCartSetCustomerEmailAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCartSetCustomerEmailAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyCartSetCustomFieldAction SetCustomField(Action<commercetools.Sdk.Api.Models.Me.MyCartSetCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCartSetCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyCartSetCustomTypeAction SetCustomType(Action<commercetools.Sdk.Api.Models.Me.MyCartSetCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCartSetCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyCartSetDeleteDaysAfterLastModificationAction SetDeleteDaysAfterLastModification(Action<commercetools.Sdk.Api.Models.Me.MyCartSetDeleteDaysAfterLastModificationAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCartSetDeleteDaysAfterLastModificationAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyCartSetLineItemCustomFieldAction SetLineItemCustomField(Action<commercetools.Sdk.Api.Models.Me.MyCartSetLineItemCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCartSetLineItemCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyCartSetLineItemCustomTypeAction SetLineItemCustomType(Action<commercetools.Sdk.Api.Models.Me.MyCartSetLineItemCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCartSetLineItemCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyCartSetLineItemDistributionChannelAction SetLineItemDistributionChannel(Action<commercetools.Sdk.Api.Models.Me.MyCartSetLineItemDistributionChannelAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCartSetLineItemDistributionChannelAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyCartSetLineItemShippingDetailsAction SetLineItemShippingDetails(Action<commercetools.Sdk.Api.Models.Me.MyCartSetLineItemShippingDetailsAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCartSetLineItemShippingDetailsAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyCartSetLineItemSupplyChannelAction SetLineItemSupplyChannel(Action<commercetools.Sdk.Api.Models.Me.MyCartSetLineItemSupplyChannelAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCartSetLineItemSupplyChannelAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyCartSetLocaleAction SetLocale(Action<commercetools.Sdk.Api.Models.Me.MyCartSetLocaleAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCartSetLocaleAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyCartSetShippingAddressAction SetShippingAddress(Action<commercetools.Sdk.Api.Models.Me.MyCartSetShippingAddressAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCartSetShippingAddressAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyCartSetShippingMethodAction SetShippingMethod(Action<commercetools.Sdk.Api.Models.Me.MyCartSetShippingMethodAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCartSetShippingMethodAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyCartUpdateItemShippingAddressAction UpdateItemShippingAddress(Action<commercetools.Sdk.Api.Models.Me.MyCartUpdateItemShippingAddressAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCartUpdateItemShippingAddressAction();
            init?.Invoke(t);
            return t;
        }
    }
}
