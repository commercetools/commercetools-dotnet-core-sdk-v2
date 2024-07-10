using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartUpdateQueryBuilderDsl
    {
        public CartUpdateQueryBuilderDsl()
        {
        }

        public static CartUpdateQueryBuilderDsl Of()
        {
            return new CartUpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartUpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<CartUpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<CartUpdateQueryBuilderDsl>(p, CartUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartUpdateActionQueryBuilderDsl.Of())),
                CartUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CartUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<CartUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<CartUpdateQueryBuilderDsl>(p, CartUpdateQueryBuilderDsl.Of));
        }

    }
}
