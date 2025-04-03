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
