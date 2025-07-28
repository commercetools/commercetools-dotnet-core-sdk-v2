using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class RecurringOrderExpiresAtSetMessageQueryBuilderDsl
    {
        public RecurringOrderExpiresAtSetMessageQueryBuilderDsl()
        {
        }

        public static RecurringOrderExpiresAtSetMessageQueryBuilderDsl Of()
        {
            return new RecurringOrderExpiresAtSetMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurringOrderExpiresAtSetMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<RecurringOrderExpiresAtSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<RecurringOrderExpiresAtSetMessageQueryBuilderDsl>(p, RecurringOrderExpiresAtSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurringOrderExpiresAtSetMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<RecurringOrderExpiresAtSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<RecurringOrderExpiresAtSetMessageQueryBuilderDsl>(p, RecurringOrderExpiresAtSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurringOrderExpiresAtSetMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<RecurringOrderExpiresAtSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<RecurringOrderExpiresAtSetMessageQueryBuilderDsl>(p, RecurringOrderExpiresAtSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurringOrderExpiresAtSetMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<RecurringOrderExpiresAtSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<RecurringOrderExpiresAtSetMessageQueryBuilderDsl>(p, RecurringOrderExpiresAtSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<RecurringOrderExpiresAtSetMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringOrderExpiresAtSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                RecurringOrderExpiresAtSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<RecurringOrderExpiresAtSetMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringOrderExpiresAtSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                RecurringOrderExpiresAtSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<RecurringOrderExpiresAtSetMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<RecurringOrderExpiresAtSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<RecurringOrderExpiresAtSetMessageQueryBuilderDsl>(p, RecurringOrderExpiresAtSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<RecurringOrderExpiresAtSetMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringOrderExpiresAtSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                RecurringOrderExpiresAtSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<RecurringOrderExpiresAtSetMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<RecurringOrderExpiresAtSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<RecurringOrderExpiresAtSetMessageQueryBuilderDsl>(p, RecurringOrderExpiresAtSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurringOrderExpiresAtSetMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<RecurringOrderExpiresAtSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<RecurringOrderExpiresAtSetMessageQueryBuilderDsl>(p, RecurringOrderExpiresAtSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<RecurringOrderExpiresAtSetMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringOrderExpiresAtSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                RecurringOrderExpiresAtSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<RecurringOrderExpiresAtSetMessageQueryBuilderDsl, DateTime> NewExpiresAt()
        {
            return new ComparisonPredicateBuilder<RecurringOrderExpiresAtSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("newExpiresAt")),
            p => new CombinationQueryPredicate<RecurringOrderExpiresAtSetMessageQueryBuilderDsl>(p, RecurringOrderExpiresAtSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurringOrderExpiresAtSetMessageQueryBuilderDsl, DateTime> OldExpiresAt()
        {
            return new ComparisonPredicateBuilder<RecurringOrderExpiresAtSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldExpiresAt")),
            p => new CombinationQueryPredicate<RecurringOrderExpiresAtSetMessageQueryBuilderDsl>(p, RecurringOrderExpiresAtSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
