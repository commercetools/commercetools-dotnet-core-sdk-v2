using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class RecurringOrderFailedMessageQueryBuilderDsl
    {
        public RecurringOrderFailedMessageQueryBuilderDsl()
        {
        }

        public static RecurringOrderFailedMessageQueryBuilderDsl Of()
        {
            return new RecurringOrderFailedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurringOrderFailedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<RecurringOrderFailedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<RecurringOrderFailedMessageQueryBuilderDsl>(p, RecurringOrderFailedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurringOrderFailedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<RecurringOrderFailedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<RecurringOrderFailedMessageQueryBuilderDsl>(p, RecurringOrderFailedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurringOrderFailedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<RecurringOrderFailedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<RecurringOrderFailedMessageQueryBuilderDsl>(p, RecurringOrderFailedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurringOrderFailedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<RecurringOrderFailedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<RecurringOrderFailedMessageQueryBuilderDsl>(p, RecurringOrderFailedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<RecurringOrderFailedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringOrderFailedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                RecurringOrderFailedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<RecurringOrderFailedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringOrderFailedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                RecurringOrderFailedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<RecurringOrderFailedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<RecurringOrderFailedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<RecurringOrderFailedMessageQueryBuilderDsl>(p, RecurringOrderFailedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<RecurringOrderFailedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringOrderFailedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                RecurringOrderFailedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<RecurringOrderFailedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<RecurringOrderFailedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<RecurringOrderFailedMessageQueryBuilderDsl>(p, RecurringOrderFailedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurringOrderFailedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<RecurringOrderFailedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<RecurringOrderFailedMessageQueryBuilderDsl>(p, RecurringOrderFailedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<RecurringOrderFailedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringOrderFailedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                RecurringOrderFailedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<RecurringOrderFailedMessageQueryBuilderDsl, string> CartId()
        {
            return new ComparisonPredicateBuilder<RecurringOrderFailedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("cartId")),
            p => new CombinationQueryPredicate<RecurringOrderFailedMessageQueryBuilderDsl>(p, RecurringOrderFailedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurringOrderFailedMessageQueryBuilderDsl, DateTime> FailedAt()
        {
            return new ComparisonPredicateBuilder<RecurringOrderFailedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("failedAt")),
            p => new CombinationQueryPredicate<RecurringOrderFailedMessageQueryBuilderDsl>(p, RecurringOrderFailedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurringOrderFailedMessageQueryBuilderDsl, string> FailureReason()
        {
            return new ComparisonPredicateBuilder<RecurringOrderFailedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("failureReason")),
            p => new CombinationQueryPredicate<RecurringOrderFailedMessageQueryBuilderDsl>(p, RecurringOrderFailedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurringOrderFailedMessageQueryBuilderDsl, DateTime> OrderScheduledAt()
        {
            return new ComparisonPredicateBuilder<RecurringOrderFailedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("orderScheduledAt")),
            p => new CombinationQueryPredicate<RecurringOrderFailedMessageQueryBuilderDsl>(p, RecurringOrderFailedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<RecurringOrderFailedMessageQueryBuilderDsl> Errors(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.RecurringOrderFailureErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.RecurringOrderFailureErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringOrderFailedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("errors"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.RecurringOrderFailureErrorQueryBuilderDsl.Of())),
                RecurringOrderFailedMessageQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<RecurringOrderFailedMessageQueryBuilderDsl> Errors()
        {
            return new CollectionPredicateBuilder<RecurringOrderFailedMessageQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("errors")),
                    p => new CombinationQueryPredicate<RecurringOrderFailedMessageQueryBuilderDsl>(p, RecurringOrderFailedMessageQueryBuilderDsl.Of));
        }

    }
}
