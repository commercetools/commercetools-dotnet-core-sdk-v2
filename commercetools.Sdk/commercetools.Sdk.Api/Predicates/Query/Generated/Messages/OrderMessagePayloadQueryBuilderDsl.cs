using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class OrderMessagePayloadQueryBuilderDsl
    {
        public OrderMessagePayloadQueryBuilderDsl()
        {
        }

        public static OrderMessagePayloadQueryBuilderDsl Of()
        {
            return new OrderMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl>(p, OrderMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl> AsCustomLineItemStateTransition(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomLineItemStateTransitionMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomLineItemStateTransitionMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomLineItemStateTransitionMessagePayloadQueryBuilderDsl.Of()),
                OrderMessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl> AsDeliveryAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.DeliveryAddedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.DeliveryAddedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.DeliveryAddedMessagePayloadQueryBuilderDsl.Of()),
                OrderMessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl> AsDeliveryAddressSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.DeliveryAddressSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.DeliveryAddressSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.DeliveryAddressSetMessagePayloadQueryBuilderDsl.Of()),
                OrderMessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl> AsDeliveryItemsUpdated(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.DeliveryItemsUpdatedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.DeliveryItemsUpdatedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.DeliveryItemsUpdatedMessagePayloadQueryBuilderDsl.Of()),
                OrderMessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl> AsDeliveryRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.DeliveryRemovedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.DeliveryRemovedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.DeliveryRemovedMessagePayloadQueryBuilderDsl.Of()),
                OrderMessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl> AsLineItemStateTransition(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.LineItemStateTransitionMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.LineItemStateTransitionMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.LineItemStateTransitionMessagePayloadQueryBuilderDsl.Of()),
                OrderMessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl> AsOrderBillingAddressSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderBillingAddressSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderBillingAddressSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderBillingAddressSetMessagePayloadQueryBuilderDsl.Of()),
                OrderMessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl> AsOrderCreated(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCreatedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCreatedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderCreatedMessagePayloadQueryBuilderDsl.Of()),
                OrderMessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl> AsOrderCustomFieldAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomFieldAddedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomFieldAddedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomFieldAddedMessagePayloadQueryBuilderDsl.Of()),
                OrderMessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl> AsOrderCustomFieldChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomFieldChangedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomFieldChangedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomFieldChangedMessagePayloadQueryBuilderDsl.Of()),
                OrderMessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl> AsOrderCustomFieldRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomFieldRemovedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomFieldRemovedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomFieldRemovedMessagePayloadQueryBuilderDsl.Of()),
                OrderMessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl> AsOrderCustomLineItemAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomLineItemAddedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomLineItemAddedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomLineItemAddedMessagePayloadQueryBuilderDsl.Of()),
                OrderMessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl> AsOrderCustomLineItemDiscountSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomLineItemDiscountSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomLineItemDiscountSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomLineItemDiscountSetMessagePayloadQueryBuilderDsl.Of()),
                OrderMessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl> AsOrderCustomLineItemQuantityChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomLineItemQuantityChangedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomLineItemQuantityChangedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomLineItemQuantityChangedMessagePayloadQueryBuilderDsl.Of()),
                OrderMessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl> AsOrderCustomLineItemRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomLineItemRemovedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomLineItemRemovedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomLineItemRemovedMessagePayloadQueryBuilderDsl.Of()),
                OrderMessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl> AsOrderCustomTypeRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomTypeRemovedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomTypeRemovedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomTypeRemovedMessagePayloadQueryBuilderDsl.Of()),
                OrderMessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl> AsOrderCustomTypeSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomTypeSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomTypeSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomTypeSetMessagePayloadQueryBuilderDsl.Of()),
                OrderMessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl> AsOrderCustomerEmailSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomerEmailSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomerEmailSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomerEmailSetMessagePayloadQueryBuilderDsl.Of()),
                OrderMessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl> AsOrderCustomerGroupSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomerGroupSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomerGroupSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomerGroupSetMessagePayloadQueryBuilderDsl.Of()),
                OrderMessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl> AsOrderCustomerSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomerSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomerSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomerSetMessagePayloadQueryBuilderDsl.Of()),
                OrderMessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl> AsOrderDeleted(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderDeletedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderDeletedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderDeletedMessagePayloadQueryBuilderDsl.Of()),
                OrderMessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl> AsOrderDiscountCodeAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderDiscountCodeAddedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderDiscountCodeAddedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderDiscountCodeAddedMessagePayloadQueryBuilderDsl.Of()),
                OrderMessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl> AsOrderDiscountCodeRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderDiscountCodeRemovedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderDiscountCodeRemovedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderDiscountCodeRemovedMessagePayloadQueryBuilderDsl.Of()),
                OrderMessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl> AsOrderDiscountCodeStateSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderDiscountCodeStateSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderDiscountCodeStateSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderDiscountCodeStateSetMessagePayloadQueryBuilderDsl.Of()),
                OrderMessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl> AsOrderEditApplied(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderEditAppliedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderEditAppliedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderEditAppliedMessagePayloadQueryBuilderDsl.Of()),
                OrderMessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl> AsOrderImported(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderImportedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderImportedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderImportedMessagePayloadQueryBuilderDsl.Of()),
                OrderMessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl> AsOrderLineItemAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderLineItemAddedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderLineItemAddedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderLineItemAddedMessagePayloadQueryBuilderDsl.Of()),
                OrderMessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl> AsOrderLineItemDiscountSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderLineItemDiscountSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderLineItemDiscountSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderLineItemDiscountSetMessagePayloadQueryBuilderDsl.Of()),
                OrderMessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl> AsOrderLineItemDistributionChannelSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderLineItemDistributionChannelSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderLineItemDistributionChannelSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderLineItemDistributionChannelSetMessagePayloadQueryBuilderDsl.Of()),
                OrderMessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl> AsOrderLineItemRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderLineItemRemovedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderLineItemRemovedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderLineItemRemovedMessagePayloadQueryBuilderDsl.Of()),
                OrderMessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl> AsOrderPaymentStateChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderPaymentStateChangedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderPaymentStateChangedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderPaymentStateChangedMessagePayloadQueryBuilderDsl.Of()),
                OrderMessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl> AsOrderPurchaseOrderNumberSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderPurchaseOrderNumberSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderPurchaseOrderNumberSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderPurchaseOrderNumberSetMessagePayloadQueryBuilderDsl.Of()),
                OrderMessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl> AsOrderReturnShipmentStateChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderReturnShipmentStateChangedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderReturnShipmentStateChangedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderReturnShipmentStateChangedMessagePayloadQueryBuilderDsl.Of()),
                OrderMessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl> AsOrderShipmentStateChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderShipmentStateChangedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderShipmentStateChangedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderShipmentStateChangedMessagePayloadQueryBuilderDsl.Of()),
                OrderMessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl> AsOrderShippingAddressSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderShippingAddressSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderShippingAddressSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderShippingAddressSetMessagePayloadQueryBuilderDsl.Of()),
                OrderMessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl> AsOrderShippingInfoSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderShippingInfoSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderShippingInfoSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderShippingInfoSetMessagePayloadQueryBuilderDsl.Of()),
                OrderMessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl> AsOrderShippingRateInputSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderShippingRateInputSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderShippingRateInputSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderShippingRateInputSetMessagePayloadQueryBuilderDsl.Of()),
                OrderMessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl> AsOrderStateChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderStateChangedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderStateChangedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderStateChangedMessagePayloadQueryBuilderDsl.Of()),
                OrderMessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl> AsOrderStateTransition(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderStateTransitionMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderStateTransitionMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderStateTransitionMessagePayloadQueryBuilderDsl.Of()),
                OrderMessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl> AsOrderStoreSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderStoreSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderStoreSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderStoreSetMessagePayloadQueryBuilderDsl.Of()),
                OrderMessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl> AsParcelAddedToDelivery(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ParcelAddedToDeliveryMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ParcelAddedToDeliveryMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ParcelAddedToDeliveryMessagePayloadQueryBuilderDsl.Of()),
                OrderMessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl> AsParcelItemsUpdated(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ParcelItemsUpdatedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ParcelItemsUpdatedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ParcelItemsUpdatedMessagePayloadQueryBuilderDsl.Of()),
                OrderMessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl> AsParcelMeasurementsUpdated(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ParcelMeasurementsUpdatedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ParcelMeasurementsUpdatedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ParcelMeasurementsUpdatedMessagePayloadQueryBuilderDsl.Of()),
                OrderMessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl> AsParcelRemovedFromDelivery(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ParcelRemovedFromDeliveryMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ParcelRemovedFromDeliveryMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ParcelRemovedFromDeliveryMessagePayloadQueryBuilderDsl.Of()),
                OrderMessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl> AsParcelTrackingDataUpdated(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ParcelTrackingDataUpdatedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ParcelTrackingDataUpdatedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ParcelTrackingDataUpdatedMessagePayloadQueryBuilderDsl.Of()),
                OrderMessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl> AsReturnInfoAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ReturnInfoAddedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ReturnInfoAddedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ReturnInfoAddedMessagePayloadQueryBuilderDsl.Of()),
                OrderMessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl> AsReturnInfoSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ReturnInfoSetMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ReturnInfoSetMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ReturnInfoSetMessagePayloadQueryBuilderDsl.Of()),
                OrderMessagePayloadQueryBuilderDsl.Of);
        }
    }
}
