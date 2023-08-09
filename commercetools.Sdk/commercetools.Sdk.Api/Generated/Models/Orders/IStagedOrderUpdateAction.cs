using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Orders.StagedOrderUpdateAction))]
    [SubTypeDiscriminator("addCustomLineItem", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderAddCustomLineItemAction))]
    [SubTypeDiscriminator("addDelivery", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderAddDeliveryAction))]
    [SubTypeDiscriminator("addDiscountCode", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderAddDiscountCodeAction))]
    [SubTypeDiscriminator("addItemShippingAddress", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderAddItemShippingAddressAction))]
    [SubTypeDiscriminator("addLineItem", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderAddLineItemAction))]
    [SubTypeDiscriminator("addParcelToDelivery", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderAddParcelToDeliveryAction))]
    [SubTypeDiscriminator("addPayment", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderAddPaymentAction))]
    [SubTypeDiscriminator("addReturnInfo", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderAddReturnInfoAction))]
    [SubTypeDiscriminator("addShoppingList", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderAddShoppingListAction))]
    [SubTypeDiscriminator("changeCustomLineItemMoney", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderChangeCustomLineItemMoneyAction))]
    [SubTypeDiscriminator("changeCustomLineItemQuantity", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderChangeCustomLineItemQuantityAction))]
    [SubTypeDiscriminator("changeLineItemQuantity", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderChangeLineItemQuantityAction))]
    [SubTypeDiscriminator("changeOrderState", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderChangeOrderStateAction))]
    [SubTypeDiscriminator("changePaymentState", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderChangePaymentStateAction))]
    [SubTypeDiscriminator("changeShipmentState", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderChangeShipmentStateAction))]
    [SubTypeDiscriminator("changeTaxCalculationMode", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderChangeTaxCalculationModeAction))]
    [SubTypeDiscriminator("changeTaxMode", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderChangeTaxModeAction))]
    [SubTypeDiscriminator("changeTaxRoundingMode", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderChangeTaxRoundingModeAction))]
    [SubTypeDiscriminator("importCustomLineItemState", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderImportCustomLineItemStateAction))]
    [SubTypeDiscriminator("importLineItemState", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderImportLineItemStateAction))]
    [SubTypeDiscriminator("removeCustomLineItem", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderRemoveCustomLineItemAction))]
    [SubTypeDiscriminator("removeDelivery", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderRemoveDeliveryAction))]
    [SubTypeDiscriminator("removeDiscountCode", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderRemoveDiscountCodeAction))]
    [SubTypeDiscriminator("removeItemShippingAddress", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderRemoveItemShippingAddressAction))]
    [SubTypeDiscriminator("removeLineItem", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderRemoveLineItemAction))]
    [SubTypeDiscriminator("removeParcelFromDelivery", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderRemoveParcelFromDeliveryAction))]
    [SubTypeDiscriminator("removePayment", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderRemovePaymentAction))]
    [SubTypeDiscriminator("setBillingAddress", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetBillingAddressAction))]
    [SubTypeDiscriminator("setBillingAddressCustomField", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetBillingAddressCustomFieldAction))]
    [SubTypeDiscriminator("setBillingAddressCustomType", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetBillingAddressCustomTypeAction))]
    [SubTypeDiscriminator("setCountry", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCountryAction))]
    [SubTypeDiscriminator("setCustomerEmail", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomerEmailAction))]
    [SubTypeDiscriminator("setCustomerGroup", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomerGroupAction))]
    [SubTypeDiscriminator("setCustomerId", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomerIdAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomLineItemCustomField", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomLineItemCustomFieldAction))]
    [SubTypeDiscriminator("setCustomLineItemCustomType", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomLineItemCustomTypeAction))]
    [SubTypeDiscriminator("setCustomLineItemShippingDetails", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomLineItemShippingDetailsAction))]
    [SubTypeDiscriminator("setCustomLineItemTaxAmount", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomLineItemTaxAmountAction))]
    [SubTypeDiscriminator("setCustomLineItemTaxRate", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomLineItemTaxRateAction))]
    [SubTypeDiscriminator("setCustomShippingMethod", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomShippingMethodAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomTypeAction))]
    [SubTypeDiscriminator("setDeliveryAddress", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetDeliveryAddressAction))]
    [SubTypeDiscriminator("setDeliveryAddressCustomField", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetDeliveryAddressCustomFieldAction))]
    [SubTypeDiscriminator("setDeliveryAddressCustomType", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetDeliveryAddressCustomTypeAction))]
    [SubTypeDiscriminator("setDeliveryCustomField", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetDeliveryCustomFieldAction))]
    [SubTypeDiscriminator("setDeliveryCustomType", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetDeliveryCustomTypeAction))]
    [SubTypeDiscriminator("setDeliveryItems", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetDeliveryItemsAction))]
    [SubTypeDiscriminator("setDirectDiscounts", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetDirectDiscountsAction))]
    [SubTypeDiscriminator("setItemShippingAddressCustomField", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetItemShippingAddressCustomFieldAction))]
    [SubTypeDiscriminator("setItemShippingAddressCustomType", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetItemShippingAddressCustomTypeAction))]
    [SubTypeDiscriminator("setLineItemCustomField", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetLineItemCustomFieldAction))]
    [SubTypeDiscriminator("setLineItemCustomType", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetLineItemCustomTypeAction))]
    [SubTypeDiscriminator("setLineItemDistributionChannel", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetLineItemDistributionChannelAction))]
    [SubTypeDiscriminator("setLineItemPrice", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetLineItemPriceAction))]
    [SubTypeDiscriminator("setLineItemShippingDetails", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetLineItemShippingDetailsAction))]
    [SubTypeDiscriminator("setLineItemTaxAmount", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetLineItemTaxAmountAction))]
    [SubTypeDiscriminator("setLineItemTaxRate", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetLineItemTaxRateAction))]
    [SubTypeDiscriminator("setLineItemTotalPrice", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetLineItemTotalPriceAction))]
    [SubTypeDiscriminator("setLocale", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetLocaleAction))]
    [SubTypeDiscriminator("setOrderNumber", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetOrderNumberAction))]
    [SubTypeDiscriminator("setOrderTotalTax", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetOrderTotalTaxAction))]
    [SubTypeDiscriminator("setParcelCustomField", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetParcelCustomFieldAction))]
    [SubTypeDiscriminator("setParcelCustomType", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetParcelCustomTypeAction))]
    [SubTypeDiscriminator("setParcelItems", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetParcelItemsAction))]
    [SubTypeDiscriminator("setParcelMeasurements", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetParcelMeasurementsAction))]
    [SubTypeDiscriminator("setParcelTrackingData", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetParcelTrackingDataAction))]
    [SubTypeDiscriminator("setPurchaseOrderNumber", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetPurchaseOrderNumberAction))]
    [SubTypeDiscriminator("setReturnInfo", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetReturnInfoAction))]
    [SubTypeDiscriminator("setReturnItemCustomField", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetReturnItemCustomFieldAction))]
    [SubTypeDiscriminator("setReturnItemCustomType", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetReturnItemCustomTypeAction))]
    [SubTypeDiscriminator("setReturnPaymentState", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetReturnPaymentStateAction))]
    [SubTypeDiscriminator("setReturnShipmentState", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetReturnShipmentStateAction))]
    [SubTypeDiscriminator("setShippingAddress", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetShippingAddressAction))]
    [SubTypeDiscriminator("setShippingAddressAndCustomShippingMethod", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetShippingAddressAndCustomShippingMethodAction))]
    [SubTypeDiscriminator("setShippingAddressAndShippingMethod", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetShippingAddressAndShippingMethodAction))]
    [SubTypeDiscriminator("setShippingAddressCustomField", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetShippingAddressCustomFieldAction))]
    [SubTypeDiscriminator("setShippingAddressCustomType", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetShippingAddressCustomTypeAction))]
    [SubTypeDiscriminator("setShippingMethod", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetShippingMethodAction))]
    [SubTypeDiscriminator("setShippingMethodTaxAmount", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetShippingMethodTaxAmountAction))]
    [SubTypeDiscriminator("setShippingMethodTaxRate", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetShippingMethodTaxRateAction))]
    [SubTypeDiscriminator("setShippingRateInput", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetShippingRateInputAction))]
    [SubTypeDiscriminator("setStore", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetStoreAction))]
    [SubTypeDiscriminator("transitionCustomLineItemState", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderTransitionCustomLineItemStateAction))]
    [SubTypeDiscriminator("transitionLineItemState", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderTransitionLineItemStateAction))]
    [SubTypeDiscriminator("transitionState", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderTransitionStateAction))]
    [SubTypeDiscriminator("updateItemShippingAddress", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderUpdateItemShippingAddressAction))]
    [SubTypeDiscriminator("updateSyncInfo", typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderUpdateSyncInfoAction))]
    public partial interface IStagedOrderUpdateAction
    {
        string Action { get; set; }

        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderAddCustomLineItemAction AddCustomLineItem(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderAddCustomLineItemAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderAddCustomLineItemAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderAddDeliveryAction AddDelivery(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderAddDeliveryAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderAddDeliveryAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderAddDiscountCodeAction AddDiscountCode(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderAddDiscountCodeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderAddDiscountCodeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderAddItemShippingAddressAction AddItemShippingAddress(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderAddItemShippingAddressAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderAddItemShippingAddressAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderAddLineItemAction AddLineItem(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderAddLineItemAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderAddLineItemAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderAddParcelToDeliveryAction AddParcelToDelivery(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderAddParcelToDeliveryAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderAddParcelToDeliveryAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderAddPaymentAction AddPayment(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderAddPaymentAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderAddPaymentAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderAddReturnInfoAction AddReturnInfo(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderAddReturnInfoAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderAddReturnInfoAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderAddShoppingListAction AddShoppingList(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderAddShoppingListAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderAddShoppingListAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderChangeCustomLineItemMoneyAction ChangeCustomLineItemMoney(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderChangeCustomLineItemMoneyAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderChangeCustomLineItemMoneyAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderChangeCustomLineItemQuantityAction ChangeCustomLineItemQuantity(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderChangeCustomLineItemQuantityAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderChangeCustomLineItemQuantityAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderChangeLineItemQuantityAction ChangeLineItemQuantity(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderChangeLineItemQuantityAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderChangeLineItemQuantityAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderChangeOrderStateAction ChangeOrderState(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderChangeOrderStateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderChangeOrderStateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderChangePaymentStateAction ChangePaymentState(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderChangePaymentStateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderChangePaymentStateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderChangeShipmentStateAction ChangeShipmentState(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderChangeShipmentStateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderChangeShipmentStateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderChangeTaxCalculationModeAction ChangeTaxCalculationMode(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderChangeTaxCalculationModeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderChangeTaxCalculationModeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderChangeTaxModeAction ChangeTaxMode(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderChangeTaxModeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderChangeTaxModeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderChangeTaxRoundingModeAction ChangeTaxRoundingMode(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderChangeTaxRoundingModeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderChangeTaxRoundingModeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderImportCustomLineItemStateAction ImportCustomLineItemState(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderImportCustomLineItemStateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderImportCustomLineItemStateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderImportLineItemStateAction ImportLineItemState(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderImportLineItemStateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderImportLineItemStateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderRemoveCustomLineItemAction RemoveCustomLineItem(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderRemoveCustomLineItemAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderRemoveCustomLineItemAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderRemoveDeliveryAction RemoveDelivery(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderRemoveDeliveryAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderRemoveDeliveryAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderRemoveDiscountCodeAction RemoveDiscountCode(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderRemoveDiscountCodeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderRemoveDiscountCodeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderRemoveItemShippingAddressAction RemoveItemShippingAddress(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderRemoveItemShippingAddressAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderRemoveItemShippingAddressAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderRemoveLineItemAction RemoveLineItem(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderRemoveLineItemAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderRemoveLineItemAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderRemoveParcelFromDeliveryAction RemoveParcelFromDelivery(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderRemoveParcelFromDeliveryAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderRemoveParcelFromDeliveryAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderRemovePaymentAction RemovePayment(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderRemovePaymentAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderRemovePaymentAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetBillingAddressAction SetBillingAddress(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetBillingAddressAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetBillingAddressAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetBillingAddressCustomFieldAction SetBillingAddressCustomField(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetBillingAddressCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetBillingAddressCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetBillingAddressCustomTypeAction SetBillingAddressCustomType(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetBillingAddressCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetBillingAddressCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCountryAction SetCountry(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCountryAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCountryAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomerEmailAction SetCustomerEmail(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomerEmailAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomerEmailAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomerGroupAction SetCustomerGroup(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomerGroupAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomerGroupAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomerIdAction SetCustomerId(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomerIdAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomerIdAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomFieldAction SetCustomField(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomLineItemCustomFieldAction SetCustomLineItemCustomField(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomLineItemCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomLineItemCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomLineItemCustomTypeAction SetCustomLineItemCustomType(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomLineItemCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomLineItemCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomLineItemShippingDetailsAction SetCustomLineItemShippingDetails(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomLineItemShippingDetailsAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomLineItemShippingDetailsAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomLineItemTaxAmountAction SetCustomLineItemTaxAmount(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomLineItemTaxAmountAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomLineItemTaxAmountAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomLineItemTaxRateAction SetCustomLineItemTaxRate(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomLineItemTaxRateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomLineItemTaxRateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomShippingMethodAction SetCustomShippingMethod(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomShippingMethodAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomShippingMethodAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomTypeAction SetCustomType(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetDeliveryAddressAction SetDeliveryAddress(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetDeliveryAddressAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetDeliveryAddressAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetDeliveryAddressCustomFieldAction SetDeliveryAddressCustomField(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetDeliveryAddressCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetDeliveryAddressCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetDeliveryAddressCustomTypeAction SetDeliveryAddressCustomType(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetDeliveryAddressCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetDeliveryAddressCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetDeliveryCustomFieldAction SetDeliveryCustomField(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetDeliveryCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetDeliveryCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetDeliveryCustomTypeAction SetDeliveryCustomType(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetDeliveryCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetDeliveryCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetDeliveryItemsAction SetDeliveryItems(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetDeliveryItemsAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetDeliveryItemsAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetDirectDiscountsAction SetDirectDiscounts(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetDirectDiscountsAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetDirectDiscountsAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetItemShippingAddressCustomFieldAction SetItemShippingAddressCustomField(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetItemShippingAddressCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetItemShippingAddressCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetItemShippingAddressCustomTypeAction SetItemShippingAddressCustomType(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetItemShippingAddressCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetItemShippingAddressCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetLineItemCustomFieldAction SetLineItemCustomField(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetLineItemCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetLineItemCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetLineItemCustomTypeAction SetLineItemCustomType(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetLineItemCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetLineItemCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetLineItemDistributionChannelAction SetLineItemDistributionChannel(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetLineItemDistributionChannelAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetLineItemDistributionChannelAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetLineItemPriceAction SetLineItemPrice(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetLineItemPriceAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetLineItemPriceAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetLineItemShippingDetailsAction SetLineItemShippingDetails(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetLineItemShippingDetailsAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetLineItemShippingDetailsAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetLineItemTaxAmountAction SetLineItemTaxAmount(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetLineItemTaxAmountAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetLineItemTaxAmountAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetLineItemTaxRateAction SetLineItemTaxRate(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetLineItemTaxRateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetLineItemTaxRateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetLineItemTotalPriceAction SetLineItemTotalPrice(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetLineItemTotalPriceAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetLineItemTotalPriceAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetLocaleAction SetLocale(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetLocaleAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetLocaleAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetOrderNumberAction SetOrderNumber(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetOrderNumberAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetOrderNumberAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetOrderTotalTaxAction SetOrderTotalTax(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetOrderTotalTaxAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetOrderTotalTaxAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetParcelCustomFieldAction SetParcelCustomField(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetParcelCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetParcelCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetParcelCustomTypeAction SetParcelCustomType(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetParcelCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetParcelCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetParcelItemsAction SetParcelItems(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetParcelItemsAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetParcelItemsAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetParcelMeasurementsAction SetParcelMeasurements(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetParcelMeasurementsAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetParcelMeasurementsAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetParcelTrackingDataAction SetParcelTrackingData(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetParcelTrackingDataAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetParcelTrackingDataAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetPurchaseOrderNumberAction SetPurchaseOrderNumber(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetPurchaseOrderNumberAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetPurchaseOrderNumberAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetReturnInfoAction SetReturnInfo(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetReturnInfoAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetReturnInfoAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetReturnItemCustomFieldAction SetReturnItemCustomField(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetReturnItemCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetReturnItemCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetReturnItemCustomTypeAction SetReturnItemCustomType(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetReturnItemCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetReturnItemCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetReturnPaymentStateAction SetReturnPaymentState(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetReturnPaymentStateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetReturnPaymentStateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetReturnShipmentStateAction SetReturnShipmentState(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetReturnShipmentStateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetReturnShipmentStateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetShippingAddressAction SetShippingAddress(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetShippingAddressAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetShippingAddressAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetShippingAddressAndCustomShippingMethodAction SetShippingAddressAndCustomShippingMethod(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetShippingAddressAndCustomShippingMethodAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetShippingAddressAndCustomShippingMethodAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetShippingAddressAndShippingMethodAction SetShippingAddressAndShippingMethod(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetShippingAddressAndShippingMethodAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetShippingAddressAndShippingMethodAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetShippingAddressCustomFieldAction SetShippingAddressCustomField(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetShippingAddressCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetShippingAddressCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetShippingAddressCustomTypeAction SetShippingAddressCustomType(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetShippingAddressCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetShippingAddressCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetShippingMethodAction SetShippingMethod(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetShippingMethodAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetShippingMethodAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetShippingMethodTaxAmountAction SetShippingMethodTaxAmount(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetShippingMethodTaxAmountAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetShippingMethodTaxAmountAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetShippingMethodTaxRateAction SetShippingMethodTaxRate(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetShippingMethodTaxRateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetShippingMethodTaxRateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetShippingRateInputAction SetShippingRateInput(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetShippingRateInputAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetShippingRateInputAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetStoreAction SetStore(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetStoreAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetStoreAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderTransitionCustomLineItemStateAction TransitionCustomLineItemState(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderTransitionCustomLineItemStateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderTransitionCustomLineItemStateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderTransitionLineItemStateAction TransitionLineItemState(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderTransitionLineItemStateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderTransitionLineItemStateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderTransitionStateAction TransitionState(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderTransitionStateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderTransitionStateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderUpdateItemShippingAddressAction UpdateItemShippingAddress(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderUpdateItemShippingAddressAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderUpdateItemShippingAddressAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.StagedOrderUpdateSyncInfoAction UpdateSyncInfo(Action<commercetools.Sdk.Api.Models.OrderEdits.StagedOrderUpdateSyncInfoAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.StagedOrderUpdateSyncInfoAction();
            init?.Invoke(t);
            return t;
        }
    }
}
