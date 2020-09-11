using commercetools.Api.Models.Orders;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Orders
{
    [JsonConverter(typeof(JsonSubtypes), "action")]
    [JsonSubtypes.KnownSubType(typeof(OrderAddDeliveryAction), "addDelivery")]
    [JsonSubtypes.KnownSubType(typeof(OrderAddItemShippingAddressAction), "addItemShippingAddress")]
    [JsonSubtypes.KnownSubType(typeof(OrderAddParcelToDeliveryAction), "addParcelToDelivery")]
    [JsonSubtypes.KnownSubType(typeof(OrderAddPaymentAction), "addPayment")]
    [JsonSubtypes.KnownSubType(typeof(OrderAddReturnInfoAction), "addReturnInfo")]
    [JsonSubtypes.KnownSubType(typeof(OrderChangeOrderStateAction), "changeOrderState")]
    [JsonSubtypes.KnownSubType(typeof(OrderChangePaymentStateAction), "changePaymentState")]
    [JsonSubtypes.KnownSubType(typeof(OrderChangeShipmentStateAction), "changeShipmentState")]
    [JsonSubtypes.KnownSubType(typeof(OrderImportCustomLineItemStateAction), "importCustomLineItemState")]
    [JsonSubtypes.KnownSubType(typeof(OrderImportLineItemStateAction), "importLineItemState")]
    [JsonSubtypes.KnownSubType(typeof(OrderRemoveDeliveryAction), "removeDelivery")]
    [JsonSubtypes.KnownSubType(typeof(OrderRemoveItemShippingAddressAction), "removeItemShippingAddress")]
    [JsonSubtypes.KnownSubType(typeof(OrderRemoveParcelFromDeliveryAction), "removeParcelFromDelivery")]
    [JsonSubtypes.KnownSubType(typeof(OrderRemovePaymentAction), "removePayment")]
    [JsonSubtypes.KnownSubType(typeof(OrderSetBillingAddressAction), "setBillingAddress")]
    [JsonSubtypes.KnownSubType(typeof(OrderSetCustomFieldAction), "setCustomField")]
    [JsonSubtypes.KnownSubType(typeof(OrderSetCustomLineItemCustomFieldAction), "setCustomLineItemCustomField")]
    [JsonSubtypes.KnownSubType(typeof(OrderSetCustomLineItemCustomTypeAction), "setCustomLineItemCustomType")]
    [JsonSubtypes.KnownSubType(typeof(OrderSetCustomLineItemShippingDetailsAction), "setCustomLineItemShippingDetails")]
    [JsonSubtypes.KnownSubType(typeof(OrderSetCustomTypeAction), "setCustomType")]
    [JsonSubtypes.KnownSubType(typeof(OrderSetCustomerEmailAction), "setCustomerEmail")]
    [JsonSubtypes.KnownSubType(typeof(OrderSetCustomerIdAction), "setCustomerId")]
    [JsonSubtypes.KnownSubType(typeof(OrderSetDeliveryAddressAction), "setDeliveryAddress")]
    [JsonSubtypes.KnownSubType(typeof(OrderSetDeliveryItemsAction), "setDeliveryItems")]
    [JsonSubtypes.KnownSubType(typeof(OrderSetLineItemCustomFieldAction), "setLineItemCustomField")]
    [JsonSubtypes.KnownSubType(typeof(OrderSetLineItemCustomTypeAction), "setLineItemCustomType")]
    [JsonSubtypes.KnownSubType(typeof(OrderSetLineItemShippingDetailsAction), "setLineItemShippingDetails")]
    [JsonSubtypes.KnownSubType(typeof(OrderSetLocaleAction), "setLocale")]
    [JsonSubtypes.KnownSubType(typeof(OrderSetOrderNumberAction), "setOrderNumber")]
    [JsonSubtypes.KnownSubType(typeof(OrderSetParcelItemsAction), "setParcelItems")]
    [JsonSubtypes.KnownSubType(typeof(OrderSetParcelMeasurementsAction), "setParcelMeasurements")]
    [JsonSubtypes.KnownSubType(typeof(OrderSetParcelTrackingDataAction), "setParcelTrackingData")]
    [JsonSubtypes.KnownSubType(typeof(OrderSetReturnPaymentStateAction), "setReturnPaymentState")]
    [JsonSubtypes.KnownSubType(typeof(OrderSetReturnShipmentStateAction), "setReturnShipmentState")]
    [JsonSubtypes.KnownSubType(typeof(OrderSetShippingAddressAction), "setShippingAddress")]
    [JsonSubtypes.KnownSubType(typeof(OrderSetStoreAction), "setStore")]
    [JsonSubtypes.KnownSubType(typeof(OrderTransitionCustomLineItemStateAction), "transitionCustomLineItemState")]
    [JsonSubtypes.KnownSubType(typeof(OrderTransitionLineItemStateAction), "transitionLineItemState")]
    [JsonSubtypes.KnownSubType(typeof(OrderTransitionStateAction), "transitionState")]
    [JsonSubtypes.KnownSubType(typeof(OrderUpdateItemShippingAddressAction), "updateItemShippingAddress")]
    [JsonSubtypes.KnownSubType(typeof(OrderUpdateSyncInfoAction), "updateSyncInfo")]
    public abstract class OrderUpdateAction 
    {
        public string Action { get; set;}
    }
}
