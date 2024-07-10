using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class DiscountCodeCreatedMessageQueryBuilderDsl
    {
        public DiscountCodeCreatedMessageQueryBuilderDsl()
        {
        }

        public static DiscountCodeCreatedMessageQueryBuilderDsl Of()
        {
            return new DiscountCodeCreatedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DiscountCodeCreatedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<DiscountCodeCreatedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<DiscountCodeCreatedMessageQueryBuilderDsl>(p, DiscountCodeCreatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountCodeCreatedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<DiscountCodeCreatedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<DiscountCodeCreatedMessageQueryBuilderDsl>(p, DiscountCodeCreatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountCodeCreatedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<DiscountCodeCreatedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<DiscountCodeCreatedMessageQueryBuilderDsl>(p, DiscountCodeCreatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountCodeCreatedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<DiscountCodeCreatedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<DiscountCodeCreatedMessageQueryBuilderDsl>(p, DiscountCodeCreatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DiscountCodeCreatedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountCodeCreatedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                DiscountCodeCreatedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<DiscountCodeCreatedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountCodeCreatedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                DiscountCodeCreatedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<DiscountCodeCreatedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<DiscountCodeCreatedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<DiscountCodeCreatedMessageQueryBuilderDsl>(p, DiscountCodeCreatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DiscountCodeCreatedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountCodeCreatedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                DiscountCodeCreatedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<DiscountCodeCreatedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<DiscountCodeCreatedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<DiscountCodeCreatedMessageQueryBuilderDsl>(p, DiscountCodeCreatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountCodeCreatedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<DiscountCodeCreatedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<DiscountCodeCreatedMessageQueryBuilderDsl>(p, DiscountCodeCreatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DiscountCodeCreatedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountCodeCreatedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                DiscountCodeCreatedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<DiscountCodeCreatedMessageQueryBuilderDsl> DiscountCode(
            Func<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountCodeCreatedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discountCode"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeQueryBuilderDsl.Of())),
                DiscountCodeCreatedMessageQueryBuilderDsl.Of);
        }


    }
}
