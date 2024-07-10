using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CartDiscounts
{

    public partial class CartDiscountUpdateQueryBuilderDsl
    {
        public CartDiscountUpdateQueryBuilderDsl()
        {
        }

        public static CartDiscountUpdateQueryBuilderDsl Of()
        {
            return new CartDiscountUpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartDiscountUpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<CartDiscountUpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<CartDiscountUpdateQueryBuilderDsl>(p, CartDiscountUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartDiscountUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountUpdateActionQueryBuilderDsl.Of())),
                CartDiscountUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CartDiscountUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<CartDiscountUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<CartDiscountUpdateQueryBuilderDsl>(p, CartDiscountUpdateQueryBuilderDsl.Of));
        }

    }
}
