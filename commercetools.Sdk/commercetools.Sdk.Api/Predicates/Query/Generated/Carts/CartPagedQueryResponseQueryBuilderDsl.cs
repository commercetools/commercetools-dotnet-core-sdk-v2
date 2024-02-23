using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartPagedQueryResponseQueryBuilderDsl
    {
        public CartPagedQueryResponseQueryBuilderDsl()
        {
        }

        public static CartPagedQueryResponseQueryBuilderDsl Of()
        {
            return new CartPagedQueryResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartPagedQueryResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<CartPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<CartPagedQueryResponseQueryBuilderDsl>(p, CartPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartPagedQueryResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<CartPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<CartPagedQueryResponseQueryBuilderDsl>(p, CartPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartPagedQueryResponseQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<CartPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<CartPagedQueryResponseQueryBuilderDsl>(p, CartPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartPagedQueryResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<CartPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<CartPagedQueryResponseQueryBuilderDsl>(p, CartPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartPagedQueryResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartPagedQueryResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartQueryBuilderDsl.Of())),
                CartPagedQueryResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CartPagedQueryResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<CartPagedQueryResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<CartPagedQueryResponseQueryBuilderDsl>(p, CartPagedQueryResponseQueryBuilderDsl.Of));
        }

    }
}
