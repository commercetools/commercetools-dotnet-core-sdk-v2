using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class OrderMessageQueryBuilderDsl
    {
        public OrderMessageQueryBuilderDsl()
        {
        }

        public static OrderMessageQueryBuilderDsl Of()
        {
            return new OrderMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<OrderMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(p, OrderMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<OrderMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(p, OrderMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<OrderMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(p, OrderMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<OrderMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(p, OrderMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                OrderMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                OrderMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<OrderMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(p, OrderMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                OrderMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<OrderMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(p, OrderMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(p, OrderMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                OrderMessageQueryBuilderDsl.Of);
        }


        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> AsCustomLineItemStateTransition(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.CustomLineItemStateTransitionMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.CustomLineItemStateTransitionMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.CustomLineItemStateTransitionMessageQueryBuilderDsl.Of()),
                OrderMessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> AsDeliveryAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.DeliveryAddedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.DeliveryAddedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.DeliveryAddedMessageQueryBuilderDsl.Of()),
                OrderMessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> AsDeliveryAddressSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.DeliveryAddressSetMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.DeliveryAddressSetMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.DeliveryAddressSetMessageQueryBuilderDsl.Of()),
                OrderMessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> AsDeliveryItemsUpdated(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.DeliveryItemsUpdatedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.DeliveryItemsUpdatedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.DeliveryItemsUpdatedMessageQueryBuilderDsl.Of()),
                OrderMessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> AsDeliveryRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.DeliveryRemovedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.DeliveryRemovedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.DeliveryRemovedMessageQueryBuilderDsl.Of()),
                OrderMessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> AsLineItemStateTransition(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.LineItemStateTransitionMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.LineItemStateTransitionMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.LineItemStateTransitionMessageQueryBuilderDsl.Of()),
                OrderMessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> AsOrderBillingAddressSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderBillingAddressSetMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderBillingAddressSetMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderBillingAddressSetMessageQueryBuilderDsl.Of()),
                OrderMessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> AsOrderCreated(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCreatedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCreatedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderCreatedMessageQueryBuilderDsl.Of()),
                OrderMessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> AsOrderCustomFieldAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomFieldAddedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomFieldAddedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomFieldAddedMessageQueryBuilderDsl.Of()),
                OrderMessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> AsOrderCustomFieldChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomFieldChangedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomFieldChangedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomFieldChangedMessageQueryBuilderDsl.Of()),
                OrderMessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> AsOrderCustomFieldRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomFieldRemovedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomFieldRemovedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomFieldRemovedMessageQueryBuilderDsl.Of()),
                OrderMessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> AsOrderCustomLineItemAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomLineItemAddedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomLineItemAddedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomLineItemAddedMessageQueryBuilderDsl.Of()),
                OrderMessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> AsOrderCustomLineItemDiscountSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomLineItemDiscountSetMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomLineItemDiscountSetMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomLineItemDiscountSetMessageQueryBuilderDsl.Of()),
                OrderMessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> AsOrderCustomLineItemQuantityChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomLineItemQuantityChangedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomLineItemQuantityChangedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomLineItemQuantityChangedMessageQueryBuilderDsl.Of()),
                OrderMessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> AsOrderCustomLineItemRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomLineItemRemovedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomLineItemRemovedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomLineItemRemovedMessageQueryBuilderDsl.Of()),
                OrderMessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> AsOrderCustomTypeRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomTypeRemovedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomTypeRemovedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomTypeRemovedMessageQueryBuilderDsl.Of()),
                OrderMessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> AsOrderCustomTypeSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomTypeSetMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomTypeSetMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomTypeSetMessageQueryBuilderDsl.Of()),
                OrderMessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> AsOrderCustomerEmailSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomerEmailSetMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomerEmailSetMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomerEmailSetMessageQueryBuilderDsl.Of()),
                OrderMessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> AsOrderCustomerGroupSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomerGroupSetMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomerGroupSetMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomerGroupSetMessageQueryBuilderDsl.Of()),
                OrderMessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> AsOrderCustomerSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomerSetMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomerSetMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderCustomerSetMessageQueryBuilderDsl.Of()),
                OrderMessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> AsOrderDeleted(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderDeletedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderDeletedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderDeletedMessageQueryBuilderDsl.Of()),
                OrderMessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> AsOrderDiscountCodeAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderDiscountCodeAddedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderDiscountCodeAddedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderDiscountCodeAddedMessageQueryBuilderDsl.Of()),
                OrderMessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> AsOrderDiscountCodeRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderDiscountCodeRemovedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderDiscountCodeRemovedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderDiscountCodeRemovedMessageQueryBuilderDsl.Of()),
                OrderMessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> AsOrderDiscountCodeStateSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderDiscountCodeStateSetMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderDiscountCodeStateSetMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderDiscountCodeStateSetMessageQueryBuilderDsl.Of()),
                OrderMessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> AsOrderEditApplied(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderEditAppliedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderEditAppliedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderEditAppliedMessageQueryBuilderDsl.Of()),
                OrderMessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> AsOrderImported(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderImportedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderImportedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderImportedMessageQueryBuilderDsl.Of()),
                OrderMessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> AsOrderLineItemAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderLineItemAddedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderLineItemAddedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderLineItemAddedMessageQueryBuilderDsl.Of()),
                OrderMessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> AsOrderLineItemDiscountSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderLineItemDiscountSetMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderLineItemDiscountSetMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderLineItemDiscountSetMessageQueryBuilderDsl.Of()),
                OrderMessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> AsOrderLineItemDistributionChannelSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderLineItemDistributionChannelSetMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderLineItemDistributionChannelSetMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderLineItemDistributionChannelSetMessageQueryBuilderDsl.Of()),
                OrderMessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> AsOrderLineItemRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderLineItemRemovedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderLineItemRemovedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderLineItemRemovedMessageQueryBuilderDsl.Of()),
                OrderMessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> AsOrderPaymentStateChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderPaymentStateChangedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderPaymentStateChangedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderPaymentStateChangedMessageQueryBuilderDsl.Of()),
                OrderMessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> AsOrderPurchaseOrderNumberSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderPurchaseOrderNumberSetMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderPurchaseOrderNumberSetMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderPurchaseOrderNumberSetMessageQueryBuilderDsl.Of()),
                OrderMessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> AsOrderReturnShipmentStateChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderReturnShipmentStateChangedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderReturnShipmentStateChangedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderReturnShipmentStateChangedMessageQueryBuilderDsl.Of()),
                OrderMessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> AsOrderShipmentStateChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderShipmentStateChangedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderShipmentStateChangedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderShipmentStateChangedMessageQueryBuilderDsl.Of()),
                OrderMessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> AsOrderShippingAddressSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderShippingAddressSetMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderShippingAddressSetMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderShippingAddressSetMessageQueryBuilderDsl.Of()),
                OrderMessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> AsOrderShippingInfoSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderShippingInfoSetMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderShippingInfoSetMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderShippingInfoSetMessageQueryBuilderDsl.Of()),
                OrderMessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> AsOrderShippingRateInputSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderShippingRateInputSetMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderShippingRateInputSetMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderShippingRateInputSetMessageQueryBuilderDsl.Of()),
                OrderMessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> AsOrderStateChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderStateChangedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderStateChangedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderStateChangedMessageQueryBuilderDsl.Of()),
                OrderMessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> AsOrderStateTransition(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderStateTransitionMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderStateTransitionMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderStateTransitionMessageQueryBuilderDsl.Of()),
                OrderMessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> AsOrderStoreSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.OrderStoreSetMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.OrderStoreSetMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.OrderStoreSetMessageQueryBuilderDsl.Of()),
                OrderMessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> AsParcelAddedToDelivery(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ParcelAddedToDeliveryMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ParcelAddedToDeliveryMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ParcelAddedToDeliveryMessageQueryBuilderDsl.Of()),
                OrderMessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> AsParcelItemsUpdated(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ParcelItemsUpdatedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ParcelItemsUpdatedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ParcelItemsUpdatedMessageQueryBuilderDsl.Of()),
                OrderMessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> AsParcelMeasurementsUpdated(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ParcelMeasurementsUpdatedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ParcelMeasurementsUpdatedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ParcelMeasurementsUpdatedMessageQueryBuilderDsl.Of()),
                OrderMessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> AsParcelRemovedFromDelivery(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ParcelRemovedFromDeliveryMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ParcelRemovedFromDeliveryMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ParcelRemovedFromDeliveryMessageQueryBuilderDsl.Of()),
                OrderMessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> AsParcelTrackingDataUpdated(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ParcelTrackingDataUpdatedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ParcelTrackingDataUpdatedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ParcelTrackingDataUpdatedMessageQueryBuilderDsl.Of()),
                OrderMessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> AsReturnInfoAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ReturnInfoAddedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ReturnInfoAddedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ReturnInfoAddedMessageQueryBuilderDsl.Of()),
                OrderMessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderMessageQueryBuilderDsl> AsReturnInfoSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ReturnInfoSetMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ReturnInfoSetMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderMessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ReturnInfoSetMessageQueryBuilderDsl.Of()),
                OrderMessageQueryBuilderDsl.Of);
        }
    }
}
