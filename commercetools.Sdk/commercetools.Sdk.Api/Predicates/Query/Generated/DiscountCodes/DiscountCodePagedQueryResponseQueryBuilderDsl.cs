using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.DiscountCodes
{

    public partial class DiscountCodePagedQueryResponseQueryBuilderDsl
    {
        public DiscountCodePagedQueryResponseQueryBuilderDsl()
        {
        }

        public static DiscountCodePagedQueryResponseQueryBuilderDsl Of()
        {
            return new DiscountCodePagedQueryResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DiscountCodePagedQueryResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<DiscountCodePagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<DiscountCodePagedQueryResponseQueryBuilderDsl>(p, DiscountCodePagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountCodePagedQueryResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<DiscountCodePagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<DiscountCodePagedQueryResponseQueryBuilderDsl>(p, DiscountCodePagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountCodePagedQueryResponseQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<DiscountCodePagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<DiscountCodePagedQueryResponseQueryBuilderDsl>(p, DiscountCodePagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountCodePagedQueryResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<DiscountCodePagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<DiscountCodePagedQueryResponseQueryBuilderDsl>(p, DiscountCodePagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DiscountCodePagedQueryResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountCodePagedQueryResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeQueryBuilderDsl.Of())),
                DiscountCodePagedQueryResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<DiscountCodePagedQueryResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<DiscountCodePagedQueryResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<DiscountCodePagedQueryResponseQueryBuilderDsl>(p, DiscountCodePagedQueryResponseQueryBuilderDsl.Of));
        }

    }
}
