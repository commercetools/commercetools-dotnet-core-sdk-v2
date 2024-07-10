using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CartDiscounts
{

    public partial class CartDiscountPagedQueryResponseQueryBuilderDsl
    {
        public CartDiscountPagedQueryResponseQueryBuilderDsl()
        {
        }

        public static CartDiscountPagedQueryResponseQueryBuilderDsl Of()
        {
            return new CartDiscountPagedQueryResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartDiscountPagedQueryResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<CartDiscountPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<CartDiscountPagedQueryResponseQueryBuilderDsl>(p, CartDiscountPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartDiscountPagedQueryResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<CartDiscountPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<CartDiscountPagedQueryResponseQueryBuilderDsl>(p, CartDiscountPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartDiscountPagedQueryResponseQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<CartDiscountPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<CartDiscountPagedQueryResponseQueryBuilderDsl>(p, CartDiscountPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartDiscountPagedQueryResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<CartDiscountPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<CartDiscountPagedQueryResponseQueryBuilderDsl>(p, CartDiscountPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartDiscountPagedQueryResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountPagedQueryResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountQueryBuilderDsl.Of())),
                CartDiscountPagedQueryResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CartDiscountPagedQueryResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<CartDiscountPagedQueryResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<CartDiscountPagedQueryResponseQueryBuilderDsl>(p, CartDiscountPagedQueryResponseQueryBuilderDsl.Of));
        }

    }
}
