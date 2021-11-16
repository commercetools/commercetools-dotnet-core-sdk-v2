using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Api.Models.Me.MyCartUpdateAction))]
    [SubTypeDiscriminator("addDiscountCode", typeof(commercetools.Api.Models.Me.MyCartAddDiscountCodeAction))]
    [SubTypeDiscriminator("addItemShippingAddress", typeof(commercetools.Api.Models.Me.MyCartAddItemShippingAddressAction))]
    [SubTypeDiscriminator("addLineItem", typeof(commercetools.Api.Models.Me.MyCartAddLineItemAction))]
    [SubTypeDiscriminator("addPayment", typeof(commercetools.Api.Models.Me.MyCartAddPaymentAction))]
    [SubTypeDiscriminator("applyDeltaToLineItemShippingDetailsTargets", typeof(commercetools.Api.Models.Me.MyCartApplyDeltaToLineItemShippingDetailsTargetsAction))]
    [SubTypeDiscriminator("changeLineItemQuantity", typeof(commercetools.Api.Models.Me.MyCartChangeLineItemQuantityAction))]
    [SubTypeDiscriminator("changeTaxMode", typeof(commercetools.Api.Models.Me.MyCartChangeTaxModeAction))]
    [SubTypeDiscriminator("recalculate", typeof(commercetools.Api.Models.Me.MyCartRecalculateAction))]
    [SubTypeDiscriminator("removeDiscountCode", typeof(commercetools.Api.Models.Me.MyCartRemoveDiscountCodeAction))]
    [SubTypeDiscriminator("removeItemShippingAddress", typeof(commercetools.Api.Models.Me.MyCartRemoveItemShippingAddressAction))]
    [SubTypeDiscriminator("removeLineItem", typeof(commercetools.Api.Models.Me.MyCartRemoveLineItemAction))]
    [SubTypeDiscriminator("removePayment", typeof(commercetools.Api.Models.Me.MyCartRemovePaymentAction))]
    [SubTypeDiscriminator("setBillingAddress", typeof(commercetools.Api.Models.Me.MyCartSetBillingAddressAction))]
    [SubTypeDiscriminator("setCountry", typeof(commercetools.Api.Models.Me.MyCartSetCountryAction))]
    [SubTypeDiscriminator("setCustomerEmail", typeof(commercetools.Api.Models.Me.MyCartSetCustomerEmailAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Api.Models.Me.MyCartSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Api.Models.Me.MyCartSetCustomTypeAction))]
    [SubTypeDiscriminator("setDeleteDaysAfterLastModification", typeof(commercetools.Api.Models.Me.MyCartSetDeleteDaysAfterLastModificationAction))]
    [SubTypeDiscriminator("setLineItemCustomField", typeof(commercetools.Api.Models.Me.MyCartSetLineItemCustomFieldAction))]
    [SubTypeDiscriminator("setLineItemCustomType", typeof(commercetools.Api.Models.Me.MyCartSetLineItemCustomTypeAction))]
    [SubTypeDiscriminator("setLineItemDistributionChannel", typeof(commercetools.Api.Models.Me.MyCartSetLineItemDistributionChannelAction))]
    [SubTypeDiscriminator("setLineItemShippingDetails", typeof(commercetools.Api.Models.Me.MyCartSetLineItemShippingDetailsAction))]
    [SubTypeDiscriminator("setLocale", typeof(commercetools.Api.Models.Me.MyCartSetLocaleAction))]
    [SubTypeDiscriminator("setShippingAddress", typeof(commercetools.Api.Models.Me.MyCartSetShippingAddressAction))]
    [SubTypeDiscriminator("setShippingMethod", typeof(commercetools.Api.Models.Me.MyCartSetShippingMethodAction))]
    [SubTypeDiscriminator("updateItemShippingAddress", typeof(commercetools.Api.Models.Me.MyCartUpdateItemShippingAddressAction))]
    public partial interface IMyCartUpdateAction 
    {
        string Action { get; set;}
    }
}
