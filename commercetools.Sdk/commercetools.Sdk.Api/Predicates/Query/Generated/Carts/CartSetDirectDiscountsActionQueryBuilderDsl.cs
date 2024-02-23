using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartSetDirectDiscountsActionQueryBuilderDsl
    {
        public CartSetDirectDiscountsActionQueryBuilderDsl()
        {
        }

        public static CartSetDirectDiscountsActionQueryBuilderDsl Of()
        {
            return new CartSetDirectDiscountsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartSetDirectDiscountsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartSetDirectDiscountsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartSetDirectDiscountsActionQueryBuilderDsl>(p, CartSetDirectDiscountsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartSetDirectDiscountsActionQueryBuilderDsl> Discounts(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.DirectDiscountDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.DirectDiscountDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartSetDirectDiscountsActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discounts"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.DirectDiscountDraftQueryBuilderDsl.Of())),
                CartSetDirectDiscountsActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CartSetDirectDiscountsActionQueryBuilderDsl> Discounts()
        {
            return new CollectionPredicateBuilder<CartSetDirectDiscountsActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("discounts")),
                    p => new CombinationQueryPredicate<CartSetDirectDiscountsActionQueryBuilderDsl>(p, CartSetDirectDiscountsActionQueryBuilderDsl.Of));
        }

    }
}
