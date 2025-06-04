using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Events
{

    public partial class EventQueryBuilderDsl
    {
        public EventQueryBuilderDsl()
        {
        }

        public static EventQueryBuilderDsl Of()
        {
            return new EventQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<EventQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<EventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<EventQueryBuilderDsl>(p, EventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<EventQueryBuilderDsl, string> NotificationType()
        {
            return new ComparisonPredicateBuilder<EventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("notificationType")),
            p => new CombinationQueryPredicate<EventQueryBuilderDsl>(p, EventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<EventQueryBuilderDsl, string> ResourceType()
        {
            return new ComparisonPredicateBuilder<EventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceType")),
            p => new CombinationQueryPredicate<EventQueryBuilderDsl>(p, EventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<EventQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<EventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<EventQueryBuilderDsl>(p, EventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<EventQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<EventQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<EventQueryBuilderDsl>(p, EventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<EventQueryBuilderDsl> AsCheckoutOrderCreationFailed(
            Func<commercetools.Sdk.Api.Predicates.Query.Events.CheckoutOrderCreationFailedEventQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Events.CheckoutOrderCreationFailedEventQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<EventQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Events.CheckoutOrderCreationFailedEventQueryBuilderDsl.Of()),
                EventQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<EventQueryBuilderDsl> AsCheckoutPaymentAuthorizationCancelled(
            Func<commercetools.Sdk.Api.Predicates.Query.Events.CheckoutPaymentAuthorizationCancelledEventQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Events.CheckoutPaymentAuthorizationCancelledEventQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<EventQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Events.CheckoutPaymentAuthorizationCancelledEventQueryBuilderDsl.Of()),
                EventQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<EventQueryBuilderDsl> AsCheckoutPaymentAuthorizationFailed(
            Func<commercetools.Sdk.Api.Predicates.Query.Events.CheckoutPaymentAuthorizationFailedEventQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Events.CheckoutPaymentAuthorizationFailedEventQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<EventQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Events.CheckoutPaymentAuthorizationFailedEventQueryBuilderDsl.Of()),
                EventQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<EventQueryBuilderDsl> AsCheckoutPaymentAuthorized(
            Func<commercetools.Sdk.Api.Predicates.Query.Events.CheckoutPaymentAuthorizedEventQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Events.CheckoutPaymentAuthorizedEventQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<EventQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Events.CheckoutPaymentAuthorizedEventQueryBuilderDsl.Of()),
                EventQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<EventQueryBuilderDsl> AsCheckoutPaymentCancelAuthorizationFailed(
            Func<commercetools.Sdk.Api.Predicates.Query.Events.CheckoutPaymentCancelAuthorizationFailedEventQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Events.CheckoutPaymentCancelAuthorizationFailedEventQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<EventQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Events.CheckoutPaymentCancelAuthorizationFailedEventQueryBuilderDsl.Of()),
                EventQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<EventQueryBuilderDsl> AsCheckoutPaymentChargeFailed(
            Func<commercetools.Sdk.Api.Predicates.Query.Events.CheckoutPaymentChargeFailedEventQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Events.CheckoutPaymentChargeFailedEventQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<EventQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Events.CheckoutPaymentChargeFailedEventQueryBuilderDsl.Of()),
                EventQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<EventQueryBuilderDsl> AsCheckoutPaymentCharged(
            Func<commercetools.Sdk.Api.Predicates.Query.Events.CheckoutPaymentChargedEventQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Events.CheckoutPaymentChargedEventQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<EventQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Events.CheckoutPaymentChargedEventQueryBuilderDsl.Of()),
                EventQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<EventQueryBuilderDsl> AsCheckoutPaymentRefundFailed(
            Func<commercetools.Sdk.Api.Predicates.Query.Events.CheckoutPaymentRefundFailedEventQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Events.CheckoutPaymentRefundFailedEventQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<EventQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Events.CheckoutPaymentRefundFailedEventQueryBuilderDsl.Of()),
                EventQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<EventQueryBuilderDsl> AsCheckoutPaymentRefunded(
            Func<commercetools.Sdk.Api.Predicates.Query.Events.CheckoutPaymentRefundedEventQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Events.CheckoutPaymentRefundedEventQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<EventQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Events.CheckoutPaymentRefundedEventQueryBuilderDsl.Of()),
                EventQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<EventQueryBuilderDsl> AsImportContainerCreated(
            Func<commercetools.Sdk.Api.Predicates.Query.Events.ImportContainerCreatedEventQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Events.ImportContainerCreatedEventQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<EventQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Events.ImportContainerCreatedEventQueryBuilderDsl.Of()),
                EventQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<EventQueryBuilderDsl> AsImportContainerDeleted(
            Func<commercetools.Sdk.Api.Predicates.Query.Events.ImportContainerDeletedEventQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Events.ImportContainerDeletedEventQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<EventQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Events.ImportContainerDeletedEventQueryBuilderDsl.Of()),
                EventQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<EventQueryBuilderDsl> AsImportOperationRejected(
            Func<commercetools.Sdk.Api.Predicates.Query.Events.ImportOperationRejectedEventQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Events.ImportOperationRejectedEventQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<EventQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Events.ImportOperationRejectedEventQueryBuilderDsl.Of()),
                EventQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<EventQueryBuilderDsl> AsImportUnresolved(
            Func<commercetools.Sdk.Api.Predicates.Query.Events.ImportUnresolvedEventQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Events.ImportUnresolvedEventQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<EventQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Events.ImportUnresolvedEventQueryBuilderDsl.Of()),
                EventQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<EventQueryBuilderDsl> AsImportValidationFailed(
            Func<commercetools.Sdk.Api.Predicates.Query.Events.ImportValidationFailedEventQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Events.ImportValidationFailedEventQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<EventQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Events.ImportValidationFailedEventQueryBuilderDsl.Of()),
                EventQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<EventQueryBuilderDsl> AsImportWaitForMasterVariant(
            Func<commercetools.Sdk.Api.Predicates.Query.Events.ImportWaitForMasterVariantEventQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Events.ImportWaitForMasterVariantEventQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<EventQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Events.ImportWaitForMasterVariantEventQueryBuilderDsl.Of()),
                EventQueryBuilderDsl.Of);
        }
    }
}
