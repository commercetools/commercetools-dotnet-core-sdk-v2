using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.DiscountGroups
{

    public partial class DiscountGroupPagedQueryResponseQueryBuilderDsl
    {
        public DiscountGroupPagedQueryResponseQueryBuilderDsl()
        {
        }

        public static DiscountGroupPagedQueryResponseQueryBuilderDsl Of()
        {
            return new DiscountGroupPagedQueryResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DiscountGroupPagedQueryResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<DiscountGroupPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<DiscountGroupPagedQueryResponseQueryBuilderDsl>(p, DiscountGroupPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountGroupPagedQueryResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<DiscountGroupPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<DiscountGroupPagedQueryResponseQueryBuilderDsl>(p, DiscountGroupPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountGroupPagedQueryResponseQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<DiscountGroupPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<DiscountGroupPagedQueryResponseQueryBuilderDsl>(p, DiscountGroupPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountGroupPagedQueryResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<DiscountGroupPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<DiscountGroupPagedQueryResponseQueryBuilderDsl>(p, DiscountGroupPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DiscountGroupPagedQueryResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.DiscountGroups.DiscountGroupQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.DiscountGroups.DiscountGroupQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountGroupPagedQueryResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.DiscountGroups.DiscountGroupQueryBuilderDsl.Of())),
                DiscountGroupPagedQueryResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<DiscountGroupPagedQueryResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<DiscountGroupPagedQueryResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<DiscountGroupPagedQueryResponseQueryBuilderDsl>(p, DiscountGroupPagedQueryResponseQueryBuilderDsl.Of));
        }

    }
}
