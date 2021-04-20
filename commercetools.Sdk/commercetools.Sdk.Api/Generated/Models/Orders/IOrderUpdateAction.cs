using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [TypeDiscriminator(nameof(Action))]
    [SubTypeDiscriminator("addDelivery", typeof(commercetools.Api.Models.Orders.OrderAddDeliveryAction))]
    [SubTypeDiscriminator("addItemShippingAddress", typeof(commercetools.Api.Models.Orders.OrderAddItemShippingAddressAction))]
    [SubTypeDiscriminator("addParcelToDelivery", typeof(commercetools.Api.Models.Orders.OrderAddParcelToDeliveryAction))]
    [SubTypeDiscriminator("addPayment", typeof(commercetools.Api.Models.Orders.OrderAddPaymentAction))]
    [SubTypeDiscriminator("addReturnInfo", typeof(commercetools.Api.Models.Orders.OrderAddReturnInfoAction))]
    [SubTypeDiscriminator("changeOrderState", typeof(commercetools.Api.Models.Orders.OrderChangeOrderStateAction))]
    [SubTypeDiscriminator("changePaymentState", typeof(commercetools.Api.Models.Orders.OrderChangePaymentStateAction))]
    [SubTypeDiscriminator("changeShipmentState", typeof(commercetools.Api.Models.Orders.OrderChangeShipmentStateAction))]
    [SubTypeDiscriminator("importCustomLineItemState", typeof(commercetools.Api.Models.Orders.OrderImportCustomLineItemStateAction))]
    [SubTypeDiscriminator("importLineItemState", typeof(commercetools.Api.Models.Orders.OrderImportLineItemStateAction))]
    [SubTypeDiscriminator("removeDelivery", typeof(commercetools.Api.Models.Orders.OrderRemoveDeliveryAction))]
    [SubTypeDiscriminator("removeItemShippingAddress", typeof(commercetools.Api.Models.Orders.OrderRemoveItemShippingAddressAction))]
    [SubTypeDiscriminator("removeParcelFromDelivery", typeof(commercetools.Api.Models.Orders.OrderRemoveParcelFromDeliveryAction))]
    [SubTypeDiscriminator("removePayment", typeof(commercetools.Api.Models.Orders.OrderRemovePaymentAction))]
    [SubTypeDiscriminator("setBillingAddress", typeof(commercetools.Api.Models.Orders.OrderSetBillingAddressAction))]
    [SubTypeDiscriminator("setBillingAddressCustomField", typeof(commercetools.Api.Models.Orders.OrderSetBillingAddressCustomFieldAction))]
    [SubTypeDiscriminator("setBillingAddressCustomType", typeof(commercetools.Api.Models.Orders.OrderSetBillingAddressCustomTypeAction))]
    [SubTypeDiscriminator("setCustomerEmail", typeof(commercetools.Api.Models.Orders.OrderSetCustomerEmailAction))]
    [SubTypeDiscriminator("setCustomerId", typeof(commercetools.Api.Models.Orders.OrderSetCustomerIdAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Api.Models.Orders.OrderSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomLineItemCustomField", typeof(commercetools.Api.Models.Orders.OrderSetCustomLineItemCustomFieldAction))]
    [SubTypeDiscriminator("setCustomLineItemCustomType", typeof(commercetools.Api.Models.Orders.OrderSetCustomLineItemCustomTypeAction))]
    [SubTypeDiscriminator("setCustomLineItemShippingDetails", typeof(commercetools.Api.Models.Orders.OrderSetCustomLineItemShippingDetailsAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Api.Models.Orders.OrderSetCustomTypeAction))]
    [SubTypeDiscriminator("setDeliveryAddress", typeof(commercetools.Api.Models.Orders.OrderSetDeliveryAddressAction))]
    [SubTypeDiscriminator("setDeliveryAddressCustomField", typeof(commercetools.Api.Models.Orders.OrderSetDeliveryAddressCustomFieldAction))]
    [SubTypeDiscriminator("setDeliveryAddressCustomType", typeof(commercetools.Api.Models.Orders.OrderSetDeliveryAddressCustomTypeAction))]
    [SubTypeDiscriminator("setDeliveryItems", typeof(commercetools.Api.Models.Orders.OrderSetDeliveryItemsAction))]
    [SubTypeDiscriminator("setItemShippingAddressCustomField", typeof(commercetools.Api.Models.Orders.OrderSetItemShippingAddressCustomFieldAction))]
    [SubTypeDiscriminator("setItemShippingAddressCustomType", typeof(commercetools.Api.Models.Orders.OrderSetItemShippingAddressCustomTypeAction))]
    [SubTypeDiscriminator("setLineItemCustomField", typeof(commercetools.Api.Models.Orders.OrderSetLineItemCustomFieldAction))]
    [SubTypeDiscriminator("setLineItemCustomType", typeof(commercetools.Api.Models.Orders.OrderSetLineItemCustomTypeAction))]
    [SubTypeDiscriminator("setLineItemShippingDetails", typeof(commercetools.Api.Models.Orders.OrderSetLineItemShippingDetailsAction))]
    [SubTypeDiscriminator("setLocale", typeof(commercetools.Api.Models.Orders.OrderSetLocaleAction))]
    [SubTypeDiscriminator("setOrderNumber", typeof(commercetools.Api.Models.Orders.OrderSetOrderNumberAction))]
    [SubTypeDiscriminator("setParcelItems", typeof(commercetools.Api.Models.Orders.OrderSetParcelItemsAction))]
    [SubTypeDiscriminator("setParcelMeasurements", typeof(commercetools.Api.Models.Orders.OrderSetParcelMeasurementsAction))]
    [SubTypeDiscriminator("setParcelTrackingData", typeof(commercetools.Api.Models.Orders.OrderSetParcelTrackingDataAction))]
    [SubTypeDiscriminator("setReturnPaymentState", typeof(commercetools.Api.Models.Orders.OrderSetReturnPaymentStateAction))]
    [SubTypeDiscriminator("setReturnShipmentState", typeof(commercetools.Api.Models.Orders.OrderSetReturnShipmentStateAction))]
    [SubTypeDiscriminator("setShippingAddress", typeof(commercetools.Api.Models.Orders.OrderSetShippingAddressAction))]
    [SubTypeDiscriminator("setShippingAddressCustomField", typeof(commercetools.Api.Models.Orders.OrderSetShippingAddressCustomFieldAction))]
    [SubTypeDiscriminator("setShippingAddressCustomType", typeof(commercetools.Api.Models.Orders.OrderSetShippingAddressCustomTypeAction))]
    [SubTypeDiscriminator("setStore", typeof(commercetools.Api.Models.Orders.OrderSetStoreAction))]
    [SubTypeDiscriminator("transitionCustomLineItemState", typeof(commercetools.Api.Models.Orders.OrderTransitionCustomLineItemStateAction))]
    [SubTypeDiscriminator("transitionLineItemState", typeof(commercetools.Api.Models.Orders.OrderTransitionLineItemStateAction))]
    [SubTypeDiscriminator("transitionState", typeof(commercetools.Api.Models.Orders.OrderTransitionStateAction))]
    [SubTypeDiscriminator("updateItemShippingAddress", typeof(commercetools.Api.Models.Orders.OrderUpdateItemShippingAddressAction))]
    [SubTypeDiscriminator("updateSyncInfo", typeof(commercetools.Api.Models.Orders.OrderUpdateSyncInfoAction))]
    public partial interface IOrderUpdateAction 
    {
        string Action { get; set;}
    }
}
