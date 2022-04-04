using commercetools.Base.CustomAttributes;


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
    [SubTypeDiscriminator("changeTaxMode", typeof(commercetools.Sdk.Api.Models.Me.MyCartChangeTaxModeAction))]
    [SubTypeDiscriminator("recalculate", typeof(commercetools.Sdk.Api.Models.Me.MyCartRecalculateAction))]
    [SubTypeDiscriminator("removeDiscountCode", typeof(commercetools.Sdk.Api.Models.Me.MyCartRemoveDiscountCodeAction))]
    [SubTypeDiscriminator("removeItemShippingAddress", typeof(commercetools.Sdk.Api.Models.Me.MyCartRemoveItemShippingAddressAction))]
    [SubTypeDiscriminator("removeLineItem", typeof(commercetools.Sdk.Api.Models.Me.MyCartRemoveLineItemAction))]
    [SubTypeDiscriminator("removePayment", typeof(commercetools.Sdk.Api.Models.Me.MyCartRemovePaymentAction))]
    [SubTypeDiscriminator("setBillingAddress", typeof(commercetools.Sdk.Api.Models.Me.MyCartSetBillingAddressAction))]
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
    }
}
