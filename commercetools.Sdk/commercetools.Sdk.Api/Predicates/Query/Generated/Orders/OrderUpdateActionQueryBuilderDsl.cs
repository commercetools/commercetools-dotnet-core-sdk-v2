using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderUpdateActionQueryBuilderDsl
    {
        public OrderUpdateActionQueryBuilderDsl()
        {
        }

        public static OrderUpdateActionQueryBuilderDsl Of()
        {
            return new OrderUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(p, OrderUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsAddDelivery(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderAddDeliveryActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderAddDeliveryActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderAddDeliveryActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsAddItemShippingAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderAddItemShippingAddressActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderAddItemShippingAddressActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderAddItemShippingAddressActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsAddParcelToDelivery(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderAddParcelToDeliveryActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderAddParcelToDeliveryActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderAddParcelToDeliveryActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsAddPayment(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderAddPaymentActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderAddPaymentActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderAddPaymentActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsAddReturnInfo(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderAddReturnInfoActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderAddReturnInfoActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderAddReturnInfoActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsChangeOrderState(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderChangeOrderStateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderChangeOrderStateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderChangeOrderStateActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsChangePaymentState(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderChangePaymentStateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderChangePaymentStateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderChangePaymentStateActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsChangeShipmentState(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderChangeShipmentStateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderChangeShipmentStateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderChangeShipmentStateActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsImportCustomLineItemState(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderImportCustomLineItemStateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderImportCustomLineItemStateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderImportCustomLineItemStateActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsImportLineItemState(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderImportLineItemStateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderImportLineItemStateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderImportLineItemStateActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsRemoveDelivery(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderRemoveDeliveryActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderRemoveDeliveryActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderRemoveDeliveryActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsRemoveItemShippingAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderRemoveItemShippingAddressActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderRemoveItemShippingAddressActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderRemoveItemShippingAddressActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsRemoveParcelFromDelivery(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderRemoveParcelFromDeliveryActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderRemoveParcelFromDeliveryActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderRemoveParcelFromDeliveryActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsRemovePayment(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderRemovePaymentActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderRemovePaymentActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderRemovePaymentActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsSetBillingAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetBillingAddressActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetBillingAddressActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetBillingAddressActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsSetBillingAddressCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetBillingAddressCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetBillingAddressCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetBillingAddressCustomFieldActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsSetBillingAddressCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetBillingAddressCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetBillingAddressCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetBillingAddressCustomTypeActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsSetCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetCustomFieldActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsSetCustomLineItemCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetCustomLineItemCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetCustomLineItemCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetCustomLineItemCustomFieldActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsSetCustomLineItemCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetCustomLineItemCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetCustomLineItemCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetCustomLineItemCustomTypeActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsSetCustomLineItemShippingDetails(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetCustomLineItemShippingDetailsActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetCustomLineItemShippingDetailsActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetCustomLineItemShippingDetailsActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsSetCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetCustomTypeActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsSetCustomerEmail(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetCustomerEmailActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetCustomerEmailActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetCustomerEmailActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsSetCustomerId(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetCustomerIdActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetCustomerIdActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetCustomerIdActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsSetDeliveryAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetDeliveryAddressActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetDeliveryAddressActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetDeliveryAddressActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsSetDeliveryAddressCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetDeliveryAddressCustomFieldActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsSetDeliveryAddressCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetDeliveryAddressCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetDeliveryAddressCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetDeliveryAddressCustomTypeActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsSetDeliveryCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetDeliveryCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetDeliveryCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetDeliveryCustomFieldActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsSetDeliveryCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetDeliveryCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetDeliveryCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetDeliveryCustomTypeActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsSetDeliveryItems(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetDeliveryItemsActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetDeliveryItemsActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetDeliveryItemsActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsSetItemShippingAddressCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetItemShippingAddressCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetItemShippingAddressCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetItemShippingAddressCustomFieldActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsSetItemShippingAddressCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetItemShippingAddressCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetItemShippingAddressCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetItemShippingAddressCustomTypeActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsSetLineItemCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetLineItemCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetLineItemCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetLineItemCustomFieldActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsSetLineItemCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetLineItemCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetLineItemCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetLineItemCustomTypeActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsSetLineItemShippingDetails(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetLineItemShippingDetailsActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetLineItemShippingDetailsActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetLineItemShippingDetailsActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsSetLocale(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetLocaleActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetLocaleActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetLocaleActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsSetOrderNumber(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetOrderNumberActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetOrderNumberActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetOrderNumberActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsSetParcelCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetParcelCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetParcelCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetParcelCustomFieldActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsSetParcelCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetParcelCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetParcelCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetParcelCustomTypeActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsSetParcelItems(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetParcelItemsActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetParcelItemsActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetParcelItemsActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsSetParcelMeasurements(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetParcelMeasurementsActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetParcelMeasurementsActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetParcelMeasurementsActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsSetParcelTrackingData(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetParcelTrackingDataActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetParcelTrackingDataActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetParcelTrackingDataActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsSetPurchaseOrderNumber(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetPurchaseOrderNumberActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetPurchaseOrderNumberActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetPurchaseOrderNumberActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsSetReturnInfo(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetReturnInfoActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetReturnInfoActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetReturnInfoActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsSetReturnItemCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetReturnItemCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetReturnItemCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetReturnItemCustomFieldActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsSetReturnItemCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetReturnItemCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetReturnItemCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetReturnItemCustomTypeActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsSetReturnPaymentState(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetReturnPaymentStateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetReturnPaymentStateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetReturnPaymentStateActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsSetReturnShipmentState(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetReturnShipmentStateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetReturnShipmentStateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetReturnShipmentStateActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsSetShippingAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetShippingAddressActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetShippingAddressActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetShippingAddressActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsSetShippingAddressCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetShippingAddressCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetShippingAddressCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetShippingAddressCustomFieldActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsSetShippingAddressCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetShippingAddressCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetShippingAddressCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetShippingAddressCustomTypeActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsSetStore(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetStoreActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetStoreActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSetStoreActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsTransitionCustomLineItemState(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderTransitionCustomLineItemStateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderTransitionCustomLineItemStateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderTransitionCustomLineItemStateActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsTransitionLineItemState(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderTransitionLineItemStateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderTransitionLineItemStateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderTransitionLineItemStateActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsTransitionState(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderTransitionStateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderTransitionStateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderTransitionStateActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsUpdateItemShippingAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderUpdateItemShippingAddressActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderUpdateItemShippingAddressActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderUpdateItemShippingAddressActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl> AsUpdateSyncInfo(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderUpdateSyncInfoActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderUpdateSyncInfoActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderUpdateSyncInfoActionQueryBuilderDsl.Of()),
                OrderUpdateActionQueryBuilderDsl.Of);
        }
    }
}
