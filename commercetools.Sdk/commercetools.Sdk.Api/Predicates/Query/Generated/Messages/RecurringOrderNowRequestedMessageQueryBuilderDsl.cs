using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class RecurringOrderNowRequestedMessageQueryBuilderDsl
    {
        public RecurringOrderNowRequestedMessageQueryBuilderDsl()
        {
        }

        public static RecurringOrderNowRequestedMessageQueryBuilderDsl Of()
        {
            return new RecurringOrderNowRequestedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurringOrderNowRequestedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<RecurringOrderNowRequestedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<RecurringOrderNowRequestedMessageQueryBuilderDsl>(p, RecurringOrderNowRequestedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurringOrderNowRequestedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<RecurringOrderNowRequestedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<RecurringOrderNowRequestedMessageQueryBuilderDsl>(p, RecurringOrderNowRequestedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurringOrderNowRequestedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<RecurringOrderNowRequestedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<RecurringOrderNowRequestedMessageQueryBuilderDsl>(p, RecurringOrderNowRequestedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurringOrderNowRequestedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<RecurringOrderNowRequestedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<RecurringOrderNowRequestedMessageQueryBuilderDsl>(p, RecurringOrderNowRequestedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<RecurringOrderNowRequestedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringOrderNowRequestedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                RecurringOrderNowRequestedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<RecurringOrderNowRequestedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringOrderNowRequestedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                RecurringOrderNowRequestedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<RecurringOrderNowRequestedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<RecurringOrderNowRequestedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<RecurringOrderNowRequestedMessageQueryBuilderDsl>(p, RecurringOrderNowRequestedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<RecurringOrderNowRequestedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringOrderNowRequestedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                RecurringOrderNowRequestedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<RecurringOrderNowRequestedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<RecurringOrderNowRequestedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<RecurringOrderNowRequestedMessageQueryBuilderDsl>(p, RecurringOrderNowRequestedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurringOrderNowRequestedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<RecurringOrderNowRequestedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<RecurringOrderNowRequestedMessageQueryBuilderDsl>(p, RecurringOrderNowRequestedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<RecurringOrderNowRequestedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringOrderNowRequestedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                RecurringOrderNowRequestedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<RecurringOrderNowRequestedMessageQueryBuilderDsl, DateTime> RequestedAt()
        {
            return new ComparisonPredicateBuilder<RecurringOrderNowRequestedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("requestedAt")),
            p => new CombinationQueryPredicate<RecurringOrderNowRequestedMessageQueryBuilderDsl>(p, RecurringOrderNowRequestedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurringOrderNowRequestedMessageQueryBuilderDsl, string> Reason()
        {
            return new ComparisonPredicateBuilder<RecurringOrderNowRequestedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("reason")),
            p => new CombinationQueryPredicate<RecurringOrderNowRequestedMessageQueryBuilderDsl>(p, RecurringOrderNowRequestedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
