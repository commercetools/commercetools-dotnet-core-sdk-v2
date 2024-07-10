using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Orders.OrderUpdateAction))]
    [SubTypeDiscriminator("addDelivery", typeof(commercetools.Sdk.Api.Models.Orders.OrderAddDeliveryAction))]
    [SubTypeDiscriminator("addItemShippingAddress", typeof(commercetools.Sdk.Api.Models.Orders.OrderAddItemShippingAddressAction))]
    [SubTypeDiscriminator("addParcelToDelivery", typeof(commercetools.Sdk.Api.Models.Orders.OrderAddParcelToDeliveryAction))]
    [SubTypeDiscriminator("addPayment", typeof(commercetools.Sdk.Api.Models.Orders.OrderAddPaymentAction))]
    [SubTypeDiscriminator("addReturnInfo", typeof(commercetools.Sdk.Api.Models.Orders.OrderAddReturnInfoAction))]
    [SubTypeDiscriminator("changeOrderState", typeof(commercetools.Sdk.Api.Models.Orders.OrderChangeOrderStateAction))]
    [SubTypeDiscriminator("changePaymentState", typeof(commercetools.Sdk.Api.Models.Orders.OrderChangePaymentStateAction))]
    [SubTypeDiscriminator("changeShipmentState", typeof(commercetools.Sdk.Api.Models.Orders.OrderChangeShipmentStateAction))]
    [SubTypeDiscriminator("importCustomLineItemState", typeof(commercetools.Sdk.Api.Models.Orders.OrderImportCustomLineItemStateAction))]
    [SubTypeDiscriminator("importLineItemState", typeof(commercetools.Sdk.Api.Models.Orders.OrderImportLineItemStateAction))]
    [SubTypeDiscriminator("removeDelivery", typeof(commercetools.Sdk.Api.Models.Orders.OrderRemoveDeliveryAction))]
    [SubTypeDiscriminator("removeItemShippingAddress", typeof(commercetools.Sdk.Api.Models.Orders.OrderRemoveItemShippingAddressAction))]
    [SubTypeDiscriminator("removeParcelFromDelivery", typeof(commercetools.Sdk.Api.Models.Orders.OrderRemoveParcelFromDeliveryAction))]
    [SubTypeDiscriminator("removePayment", typeof(commercetools.Sdk.Api.Models.Orders.OrderRemovePaymentAction))]
    [SubTypeDiscriminator("setBillingAddress", typeof(commercetools.Sdk.Api.Models.Orders.OrderSetBillingAddressAction))]
    [SubTypeDiscriminator("setBillingAddressCustomField", typeof(commercetools.Sdk.Api.Models.Orders.OrderSetBillingAddressCustomFieldAction))]
    [SubTypeDiscriminator("setBillingAddressCustomType", typeof(commercetools.Sdk.Api.Models.Orders.OrderSetBillingAddressCustomTypeAction))]
    [SubTypeDiscriminator("setCustomerEmail", typeof(commercetools.Sdk.Api.Models.Orders.OrderSetCustomerEmailAction))]
    [SubTypeDiscriminator("setCustomerId", typeof(commercetools.Sdk.Api.Models.Orders.OrderSetCustomerIdAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Sdk.Api.Models.Orders.OrderSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomLineItemCustomField", typeof(commercetools.Sdk.Api.Models.Orders.OrderSetCustomLineItemCustomFieldAction))]
    [SubTypeDiscriminator("setCustomLineItemCustomType", typeof(commercetools.Sdk.Api.Models.Orders.OrderSetCustomLineItemCustomTypeAction))]
    [SubTypeDiscriminator("setCustomLineItemShippingDetails", typeof(commercetools.Sdk.Api.Models.Orders.OrderSetCustomLineItemShippingDetailsAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Sdk.Api.Models.Orders.OrderSetCustomTypeAction))]
    [SubTypeDiscriminator("setDeliveryAddress", typeof(commercetools.Sdk.Api.Models.Orders.OrderSetDeliveryAddressAction))]
    [SubTypeDiscriminator("setDeliveryAddressCustomField", typeof(commercetools.Sdk.Api.Models.Orders.OrderSetDeliveryAddressCustomFieldAction))]
    [SubTypeDiscriminator("setDeliveryAddressCustomType", typeof(commercetools.Sdk.Api.Models.Orders.OrderSetDeliveryAddressCustomTypeAction))]
    [SubTypeDiscriminator("setDeliveryCustomField", typeof(commercetools.Sdk.Api.Models.Orders.OrderSetDeliveryCustomFieldAction))]
    [SubTypeDiscriminator("setDeliveryCustomType", typeof(commercetools.Sdk.Api.Models.Orders.OrderSetDeliveryCustomTypeAction))]
    [SubTypeDiscriminator("setDeliveryItems", typeof(commercetools.Sdk.Api.Models.Orders.OrderSetDeliveryItemsAction))]
    [SubTypeDiscriminator("setItemShippingAddressCustomField", typeof(commercetools.Sdk.Api.Models.Orders.OrderSetItemShippingAddressCustomFieldAction))]
    [SubTypeDiscriminator("setItemShippingAddressCustomType", typeof(commercetools.Sdk.Api.Models.Orders.OrderSetItemShippingAddressCustomTypeAction))]
    [SubTypeDiscriminator("setLineItemCustomField", typeof(commercetools.Sdk.Api.Models.Orders.OrderSetLineItemCustomFieldAction))]
    [SubTypeDiscriminator("setLineItemCustomType", typeof(commercetools.Sdk.Api.Models.Orders.OrderSetLineItemCustomTypeAction))]
    [SubTypeDiscriminator("setLineItemShippingDetails", typeof(commercetools.Sdk.Api.Models.Orders.OrderSetLineItemShippingDetailsAction))]
    [SubTypeDiscriminator("setLocale", typeof(commercetools.Sdk.Api.Models.Orders.OrderSetLocaleAction))]
    [SubTypeDiscriminator("setOrderNumber", typeof(commercetools.Sdk.Api.Models.Orders.OrderSetOrderNumberAction))]
    [SubTypeDiscriminator("setParcelCustomField", typeof(commercetools.Sdk.Api.Models.Orders.OrderSetParcelCustomFieldAction))]
    [SubTypeDiscriminator("setParcelCustomType", typeof(commercetools.Sdk.Api.Models.Orders.OrderSetParcelCustomTypeAction))]
    [SubTypeDiscriminator("setParcelItems", typeof(commercetools.Sdk.Api.Models.Orders.OrderSetParcelItemsAction))]
    [SubTypeDiscriminator("setParcelMeasurements", typeof(commercetools.Sdk.Api.Models.Orders.OrderSetParcelMeasurementsAction))]
    [SubTypeDiscriminator("setParcelTrackingData", typeof(commercetools.Sdk.Api.Models.Orders.OrderSetParcelTrackingDataAction))]
    [SubTypeDiscriminator("setPurchaseOrderNumber", typeof(commercetools.Sdk.Api.Models.Orders.OrderSetPurchaseOrderNumberAction))]
    [SubTypeDiscriminator("setReturnInfo", typeof(commercetools.Sdk.Api.Models.Orders.OrderSetReturnInfoAction))]
    [SubTypeDiscriminator("setReturnItemCustomField", typeof(commercetools.Sdk.Api.Models.Orders.OrderSetReturnItemCustomFieldAction))]
    [SubTypeDiscriminator("setReturnItemCustomType", typeof(commercetools.Sdk.Api.Models.Orders.OrderSetReturnItemCustomTypeAction))]
    [SubTypeDiscriminator("setReturnPaymentState", typeof(commercetools.Sdk.Api.Models.Orders.OrderSetReturnPaymentStateAction))]
    [SubTypeDiscriminator("setReturnShipmentState", typeof(commercetools.Sdk.Api.Models.Orders.OrderSetReturnShipmentStateAction))]
    [SubTypeDiscriminator("setShippingAddress", typeof(commercetools.Sdk.Api.Models.Orders.OrderSetShippingAddressAction))]
    [SubTypeDiscriminator("setShippingAddressCustomField", typeof(commercetools.Sdk.Api.Models.Orders.OrderSetShippingAddressCustomFieldAction))]
    [SubTypeDiscriminator("setShippingAddressCustomType", typeof(commercetools.Sdk.Api.Models.Orders.OrderSetShippingAddressCustomTypeAction))]
    [SubTypeDiscriminator("setShippingCustomField", typeof(commercetools.Sdk.Api.Models.Orders.OrderSetShippingCustomFieldAction))]
    [SubTypeDiscriminator("setShippingCustomType", typeof(commercetools.Sdk.Api.Models.Orders.OrderSetShippingCustomTypeAction))]
    [SubTypeDiscriminator("setStore", typeof(commercetools.Sdk.Api.Models.Orders.OrderSetStoreAction))]
    [SubTypeDiscriminator("transitionCustomLineItemState", typeof(commercetools.Sdk.Api.Models.Orders.OrderTransitionCustomLineItemStateAction))]
    [SubTypeDiscriminator("transitionLineItemState", typeof(commercetools.Sdk.Api.Models.Orders.OrderTransitionLineItemStateAction))]
    [SubTypeDiscriminator("transitionState", typeof(commercetools.Sdk.Api.Models.Orders.OrderTransitionStateAction))]
    [SubTypeDiscriminator("updateItemShippingAddress", typeof(commercetools.Sdk.Api.Models.Orders.OrderUpdateItemShippingAddressAction))]
    [SubTypeDiscriminator("updateSyncInfo", typeof(commercetools.Sdk.Api.Models.Orders.OrderUpdateSyncInfoAction))]
    public partial interface IOrderUpdateAction
    {
        string Action { get; set; }

        static commercetools.Sdk.Api.Models.Orders.OrderAddDeliveryAction AddDelivery(Action<commercetools.Sdk.Api.Models.Orders.OrderAddDeliveryAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderAddDeliveryAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderAddItemShippingAddressAction AddItemShippingAddress(Action<commercetools.Sdk.Api.Models.Orders.OrderAddItemShippingAddressAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderAddItemShippingAddressAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderAddParcelToDeliveryAction AddParcelToDelivery(Action<commercetools.Sdk.Api.Models.Orders.OrderAddParcelToDeliveryAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderAddParcelToDeliveryAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderAddPaymentAction AddPayment(Action<commercetools.Sdk.Api.Models.Orders.OrderAddPaymentAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderAddPaymentAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderAddReturnInfoAction AddReturnInfo(Action<commercetools.Sdk.Api.Models.Orders.OrderAddReturnInfoAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderAddReturnInfoAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderChangeOrderStateAction ChangeOrderState(Action<commercetools.Sdk.Api.Models.Orders.OrderChangeOrderStateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderChangeOrderStateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderChangePaymentStateAction ChangePaymentState(Action<commercetools.Sdk.Api.Models.Orders.OrderChangePaymentStateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderChangePaymentStateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderChangeShipmentStateAction ChangeShipmentState(Action<commercetools.Sdk.Api.Models.Orders.OrderChangeShipmentStateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderChangeShipmentStateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderImportCustomLineItemStateAction ImportCustomLineItemState(Action<commercetools.Sdk.Api.Models.Orders.OrderImportCustomLineItemStateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderImportCustomLineItemStateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderImportLineItemStateAction ImportLineItemState(Action<commercetools.Sdk.Api.Models.Orders.OrderImportLineItemStateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderImportLineItemStateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderRemoveDeliveryAction RemoveDelivery(Action<commercetools.Sdk.Api.Models.Orders.OrderRemoveDeliveryAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderRemoveDeliveryAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderRemoveItemShippingAddressAction RemoveItemShippingAddress(Action<commercetools.Sdk.Api.Models.Orders.OrderRemoveItemShippingAddressAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderRemoveItemShippingAddressAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderRemoveParcelFromDeliveryAction RemoveParcelFromDelivery(Action<commercetools.Sdk.Api.Models.Orders.OrderRemoveParcelFromDeliveryAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderRemoveParcelFromDeliveryAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderRemovePaymentAction RemovePayment(Action<commercetools.Sdk.Api.Models.Orders.OrderRemovePaymentAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderRemovePaymentAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderSetBillingAddressAction SetBillingAddress(Action<commercetools.Sdk.Api.Models.Orders.OrderSetBillingAddressAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderSetBillingAddressAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderSetBillingAddressCustomFieldAction SetBillingAddressCustomField(Action<commercetools.Sdk.Api.Models.Orders.OrderSetBillingAddressCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderSetBillingAddressCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderSetBillingAddressCustomTypeAction SetBillingAddressCustomType(Action<commercetools.Sdk.Api.Models.Orders.OrderSetBillingAddressCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderSetBillingAddressCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderSetCustomerEmailAction SetCustomerEmail(Action<commercetools.Sdk.Api.Models.Orders.OrderSetCustomerEmailAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderSetCustomerEmailAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderSetCustomerIdAction SetCustomerId(Action<commercetools.Sdk.Api.Models.Orders.OrderSetCustomerIdAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderSetCustomerIdAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderSetCustomFieldAction SetCustomField(Action<commercetools.Sdk.Api.Models.Orders.OrderSetCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderSetCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderSetCustomLineItemCustomFieldAction SetCustomLineItemCustomField(Action<commercetools.Sdk.Api.Models.Orders.OrderSetCustomLineItemCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderSetCustomLineItemCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderSetCustomLineItemCustomTypeAction SetCustomLineItemCustomType(Action<commercetools.Sdk.Api.Models.Orders.OrderSetCustomLineItemCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderSetCustomLineItemCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderSetCustomLineItemShippingDetailsAction SetCustomLineItemShippingDetails(Action<commercetools.Sdk.Api.Models.Orders.OrderSetCustomLineItemShippingDetailsAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderSetCustomLineItemShippingDetailsAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderSetCustomTypeAction SetCustomType(Action<commercetools.Sdk.Api.Models.Orders.OrderSetCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderSetCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderSetDeliveryAddressAction SetDeliveryAddress(Action<commercetools.Sdk.Api.Models.Orders.OrderSetDeliveryAddressAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderSetDeliveryAddressAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderSetDeliveryAddressCustomFieldAction SetDeliveryAddressCustomField(Action<commercetools.Sdk.Api.Models.Orders.OrderSetDeliveryAddressCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderSetDeliveryAddressCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderSetDeliveryAddressCustomTypeAction SetDeliveryAddressCustomType(Action<commercetools.Sdk.Api.Models.Orders.OrderSetDeliveryAddressCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderSetDeliveryAddressCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderSetDeliveryCustomFieldAction SetDeliveryCustomField(Action<commercetools.Sdk.Api.Models.Orders.OrderSetDeliveryCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderSetDeliveryCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderSetDeliveryCustomTypeAction SetDeliveryCustomType(Action<commercetools.Sdk.Api.Models.Orders.OrderSetDeliveryCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderSetDeliveryCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderSetDeliveryItemsAction SetDeliveryItems(Action<commercetools.Sdk.Api.Models.Orders.OrderSetDeliveryItemsAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderSetDeliveryItemsAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderSetItemShippingAddressCustomFieldAction SetItemShippingAddressCustomField(Action<commercetools.Sdk.Api.Models.Orders.OrderSetItemShippingAddressCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderSetItemShippingAddressCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderSetItemShippingAddressCustomTypeAction SetItemShippingAddressCustomType(Action<commercetools.Sdk.Api.Models.Orders.OrderSetItemShippingAddressCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderSetItemShippingAddressCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderSetLineItemCustomFieldAction SetLineItemCustomField(Action<commercetools.Sdk.Api.Models.Orders.OrderSetLineItemCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderSetLineItemCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderSetLineItemCustomTypeAction SetLineItemCustomType(Action<commercetools.Sdk.Api.Models.Orders.OrderSetLineItemCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderSetLineItemCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderSetLineItemShippingDetailsAction SetLineItemShippingDetails(Action<commercetools.Sdk.Api.Models.Orders.OrderSetLineItemShippingDetailsAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderSetLineItemShippingDetailsAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderSetLocaleAction SetLocale(Action<commercetools.Sdk.Api.Models.Orders.OrderSetLocaleAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderSetLocaleAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderSetOrderNumberAction SetOrderNumber(Action<commercetools.Sdk.Api.Models.Orders.OrderSetOrderNumberAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderSetOrderNumberAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderSetParcelCustomFieldAction SetParcelCustomField(Action<commercetools.Sdk.Api.Models.Orders.OrderSetParcelCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderSetParcelCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderSetParcelCustomTypeAction SetParcelCustomType(Action<commercetools.Sdk.Api.Models.Orders.OrderSetParcelCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderSetParcelCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderSetParcelItemsAction SetParcelItems(Action<commercetools.Sdk.Api.Models.Orders.OrderSetParcelItemsAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderSetParcelItemsAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderSetParcelMeasurementsAction SetParcelMeasurements(Action<commercetools.Sdk.Api.Models.Orders.OrderSetParcelMeasurementsAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderSetParcelMeasurementsAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderSetParcelTrackingDataAction SetParcelTrackingData(Action<commercetools.Sdk.Api.Models.Orders.OrderSetParcelTrackingDataAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderSetParcelTrackingDataAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderSetPurchaseOrderNumberAction SetPurchaseOrderNumber(Action<commercetools.Sdk.Api.Models.Orders.OrderSetPurchaseOrderNumberAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderSetPurchaseOrderNumberAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderSetReturnInfoAction SetReturnInfo(Action<commercetools.Sdk.Api.Models.Orders.OrderSetReturnInfoAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderSetReturnInfoAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderSetReturnItemCustomFieldAction SetReturnItemCustomField(Action<commercetools.Sdk.Api.Models.Orders.OrderSetReturnItemCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderSetReturnItemCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderSetReturnItemCustomTypeAction SetReturnItemCustomType(Action<commercetools.Sdk.Api.Models.Orders.OrderSetReturnItemCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderSetReturnItemCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderSetReturnPaymentStateAction SetReturnPaymentState(Action<commercetools.Sdk.Api.Models.Orders.OrderSetReturnPaymentStateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderSetReturnPaymentStateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderSetReturnShipmentStateAction SetReturnShipmentState(Action<commercetools.Sdk.Api.Models.Orders.OrderSetReturnShipmentStateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderSetReturnShipmentStateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderSetShippingAddressAction SetShippingAddress(Action<commercetools.Sdk.Api.Models.Orders.OrderSetShippingAddressAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderSetShippingAddressAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderSetShippingAddressCustomFieldAction SetShippingAddressCustomField(Action<commercetools.Sdk.Api.Models.Orders.OrderSetShippingAddressCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderSetShippingAddressCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderSetShippingAddressCustomTypeAction SetShippingAddressCustomType(Action<commercetools.Sdk.Api.Models.Orders.OrderSetShippingAddressCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderSetShippingAddressCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderSetShippingCustomFieldAction SetShippingCustomField(Action<commercetools.Sdk.Api.Models.Orders.OrderSetShippingCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderSetShippingCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderSetShippingCustomTypeAction SetShippingCustomType(Action<commercetools.Sdk.Api.Models.Orders.OrderSetShippingCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderSetShippingCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderSetStoreAction SetStore(Action<commercetools.Sdk.Api.Models.Orders.OrderSetStoreAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderSetStoreAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderTransitionCustomLineItemStateAction TransitionCustomLineItemState(Action<commercetools.Sdk.Api.Models.Orders.OrderTransitionCustomLineItemStateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderTransitionCustomLineItemStateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderTransitionLineItemStateAction TransitionLineItemState(Action<commercetools.Sdk.Api.Models.Orders.OrderTransitionLineItemStateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderTransitionLineItemStateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderTransitionStateAction TransitionState(Action<commercetools.Sdk.Api.Models.Orders.OrderTransitionStateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderTransitionStateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderUpdateItemShippingAddressAction UpdateItemShippingAddress(Action<commercetools.Sdk.Api.Models.Orders.OrderUpdateItemShippingAddressAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderUpdateItemShippingAddressAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderUpdateSyncInfoAction UpdateSyncInfo(Action<commercetools.Sdk.Api.Models.Orders.OrderUpdateSyncInfoAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderUpdateSyncInfoAction();
            init?.Invoke(t);
            return t;
        }
    }
}
