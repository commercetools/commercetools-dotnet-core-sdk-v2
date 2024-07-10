using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CartDiscounts
{

    public partial class CartDiscountChangeValueActionQueryBuilderDsl
    {
        public CartDiscountChangeValueActionQueryBuilderDsl()
        {
        }

        public static CartDiscountChangeValueActionQueryBuilderDsl Of()
        {
            return new CartDiscountChangeValueActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartDiscountChangeValueActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartDiscountChangeValueActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartDiscountChangeValueActionQueryBuilderDsl>(p, CartDiscountChangeValueActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartDiscountChangeValueActionQueryBuilderDsl> Value(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountValueDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountValueDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountChangeValueActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("value"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountValueDraftQueryBuilderDsl.Of())),
                CartDiscountChangeValueActionQueryBuilderDsl.Of);
        }


    }
}
