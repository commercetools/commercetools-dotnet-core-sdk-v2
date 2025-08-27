using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class DiscountGroupIsActiveSetMessageQueryBuilderDsl
    {
        public DiscountGroupIsActiveSetMessageQueryBuilderDsl()
        {
        }

        public static DiscountGroupIsActiveSetMessageQueryBuilderDsl Of()
        {
            return new DiscountGroupIsActiveSetMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DiscountGroupIsActiveSetMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<DiscountGroupIsActiveSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<DiscountGroupIsActiveSetMessageQueryBuilderDsl>(p, DiscountGroupIsActiveSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountGroupIsActiveSetMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<DiscountGroupIsActiveSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<DiscountGroupIsActiveSetMessageQueryBuilderDsl>(p, DiscountGroupIsActiveSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountGroupIsActiveSetMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<DiscountGroupIsActiveSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<DiscountGroupIsActiveSetMessageQueryBuilderDsl>(p, DiscountGroupIsActiveSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountGroupIsActiveSetMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<DiscountGroupIsActiveSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<DiscountGroupIsActiveSetMessageQueryBuilderDsl>(p, DiscountGroupIsActiveSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DiscountGroupIsActiveSetMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountGroupIsActiveSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                DiscountGroupIsActiveSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<DiscountGroupIsActiveSetMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountGroupIsActiveSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                DiscountGroupIsActiveSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<DiscountGroupIsActiveSetMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<DiscountGroupIsActiveSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<DiscountGroupIsActiveSetMessageQueryBuilderDsl>(p, DiscountGroupIsActiveSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DiscountGroupIsActiveSetMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountGroupIsActiveSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                DiscountGroupIsActiveSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<DiscountGroupIsActiveSetMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<DiscountGroupIsActiveSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<DiscountGroupIsActiveSetMessageQueryBuilderDsl>(p, DiscountGroupIsActiveSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountGroupIsActiveSetMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<DiscountGroupIsActiveSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<DiscountGroupIsActiveSetMessageQueryBuilderDsl>(p, DiscountGroupIsActiveSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DiscountGroupIsActiveSetMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountGroupIsActiveSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                DiscountGroupIsActiveSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<DiscountGroupIsActiveSetMessageQueryBuilderDsl, bool> IsActive()
        {
            return new ComparisonPredicateBuilder<DiscountGroupIsActiveSetMessageQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("isActive")),
            p => new CombinationQueryPredicate<DiscountGroupIsActiveSetMessageQueryBuilderDsl>(p, DiscountGroupIsActiveSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountGroupIsActiveSetMessageQueryBuilderDsl, bool> OldIsActive()
        {
            return new ComparisonPredicateBuilder<DiscountGroupIsActiveSetMessageQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldIsActive")),
            p => new CombinationQueryPredicate<DiscountGroupIsActiveSetMessageQueryBuilderDsl>(p, DiscountGroupIsActiveSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
