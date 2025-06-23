using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class DiscountGroupKeySetMessageQueryBuilderDsl
    {
        public DiscountGroupKeySetMessageQueryBuilderDsl()
        {
        }

        public static DiscountGroupKeySetMessageQueryBuilderDsl Of()
        {
            return new DiscountGroupKeySetMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DiscountGroupKeySetMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<DiscountGroupKeySetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<DiscountGroupKeySetMessageQueryBuilderDsl>(p, DiscountGroupKeySetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountGroupKeySetMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<DiscountGroupKeySetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<DiscountGroupKeySetMessageQueryBuilderDsl>(p, DiscountGroupKeySetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountGroupKeySetMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<DiscountGroupKeySetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<DiscountGroupKeySetMessageQueryBuilderDsl>(p, DiscountGroupKeySetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountGroupKeySetMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<DiscountGroupKeySetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<DiscountGroupKeySetMessageQueryBuilderDsl>(p, DiscountGroupKeySetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DiscountGroupKeySetMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountGroupKeySetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                DiscountGroupKeySetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<DiscountGroupKeySetMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountGroupKeySetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                DiscountGroupKeySetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<DiscountGroupKeySetMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<DiscountGroupKeySetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<DiscountGroupKeySetMessageQueryBuilderDsl>(p, DiscountGroupKeySetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DiscountGroupKeySetMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountGroupKeySetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                DiscountGroupKeySetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<DiscountGroupKeySetMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<DiscountGroupKeySetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<DiscountGroupKeySetMessageQueryBuilderDsl>(p, DiscountGroupKeySetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountGroupKeySetMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<DiscountGroupKeySetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<DiscountGroupKeySetMessageQueryBuilderDsl>(p, DiscountGroupKeySetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DiscountGroupKeySetMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountGroupKeySetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                DiscountGroupKeySetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<DiscountGroupKeySetMessageQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<DiscountGroupKeySetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<DiscountGroupKeySetMessageQueryBuilderDsl>(p, DiscountGroupKeySetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountGroupKeySetMessageQueryBuilderDsl, string> OldKey()
        {
            return new ComparisonPredicateBuilder<DiscountGroupKeySetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldKey")),
            p => new CombinationQueryPredicate<DiscountGroupKeySetMessageQueryBuilderDsl>(p, DiscountGroupKeySetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
