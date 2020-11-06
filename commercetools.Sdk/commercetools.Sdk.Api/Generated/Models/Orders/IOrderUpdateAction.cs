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
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Api.Models.Orders.OrderSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomLineItemCustomField", typeof(commercetools.Api.Models.Orders.OrderSetCustomLineItemCustomFieldAction))]
    [SubTypeDiscriminator("setCustomLineItemCustomType", typeof(commercetools.Api.Models.Orders.OrderSetCustomLineItemCustomTypeAction))]
    [SubTypeDiscriminator("setCustomLineItemShippingDetails", typeof(commercetools.Api.Models.Orders.OrderSetCustomLineItemShippingDetailsAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Api.Models.Orders.OrderSetCustomTypeAction))]
    [SubTypeDiscriminator("setCustomerEmail", typeof(commercetools.Api.Models.Orders.OrderSetCustomerEmailAction))]
    [SubTypeDiscriminator("setCustomerId", typeof(commercetools.Api.Models.Orders.OrderSetCustomerIdAction))]
    [SubTypeDiscriminator("setDeliveryAddress", typeof(commercetools.Api.Models.Orders.OrderSetDeliveryAddressAction))]
    [SubTypeDiscriminator("setDeliveryItems", typeof(commercetools.Api.Models.Orders.OrderSetDeliveryItemsAction))]
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
