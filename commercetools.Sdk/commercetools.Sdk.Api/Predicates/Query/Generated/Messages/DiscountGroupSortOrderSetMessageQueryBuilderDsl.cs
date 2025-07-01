using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class DiscountGroupSortOrderSetMessageQueryBuilderDsl
    {
        public DiscountGroupSortOrderSetMessageQueryBuilderDsl()
        {
        }

        public static DiscountGroupSortOrderSetMessageQueryBuilderDsl Of()
        {
            return new DiscountGroupSortOrderSetMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DiscountGroupSortOrderSetMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<DiscountGroupSortOrderSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<DiscountGroupSortOrderSetMessageQueryBuilderDsl>(p, DiscountGroupSortOrderSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountGroupSortOrderSetMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<DiscountGroupSortOrderSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<DiscountGroupSortOrderSetMessageQueryBuilderDsl>(p, DiscountGroupSortOrderSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountGroupSortOrderSetMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<DiscountGroupSortOrderSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<DiscountGroupSortOrderSetMessageQueryBuilderDsl>(p, DiscountGroupSortOrderSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountGroupSortOrderSetMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<DiscountGroupSortOrderSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<DiscountGroupSortOrderSetMessageQueryBuilderDsl>(p, DiscountGroupSortOrderSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DiscountGroupSortOrderSetMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountGroupSortOrderSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                DiscountGroupSortOrderSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<DiscountGroupSortOrderSetMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountGroupSortOrderSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                DiscountGroupSortOrderSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<DiscountGroupSortOrderSetMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<DiscountGroupSortOrderSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<DiscountGroupSortOrderSetMessageQueryBuilderDsl>(p, DiscountGroupSortOrderSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DiscountGroupSortOrderSetMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountGroupSortOrderSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                DiscountGroupSortOrderSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<DiscountGroupSortOrderSetMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<DiscountGroupSortOrderSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<DiscountGroupSortOrderSetMessageQueryBuilderDsl>(p, DiscountGroupSortOrderSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountGroupSortOrderSetMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<DiscountGroupSortOrderSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<DiscountGroupSortOrderSetMessageQueryBuilderDsl>(p, DiscountGroupSortOrderSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DiscountGroupSortOrderSetMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountGroupSortOrderSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                DiscountGroupSortOrderSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<DiscountGroupSortOrderSetMessageQueryBuilderDsl, string> SortOrder()
        {
            return new ComparisonPredicateBuilder<DiscountGroupSortOrderSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sortOrder")),
            p => new CombinationQueryPredicate<DiscountGroupSortOrderSetMessageQueryBuilderDsl>(p, DiscountGroupSortOrderSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountGroupSortOrderSetMessageQueryBuilderDsl, string> OldSortOrder()
        {
            return new ComparisonPredicateBuilder<DiscountGroupSortOrderSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldSortOrder")),
            p => new CombinationQueryPredicate<DiscountGroupSortOrderSetMessageQueryBuilderDsl>(p, DiscountGroupSortOrderSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
