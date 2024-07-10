using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CartDiscountCreatedMessagePayloadQueryBuilderDsl
    {
        public CartDiscountCreatedMessagePayloadQueryBuilderDsl()
        {
        }

        public static CartDiscountCreatedMessagePayloadQueryBuilderDsl Of()
        {
            return new CartDiscountCreatedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartDiscountCreatedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CartDiscountCreatedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CartDiscountCreatedMessagePayloadQueryBuilderDsl>(p, CartDiscountCreatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartDiscountCreatedMessagePayloadQueryBuilderDsl> CartDiscount(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountCreatedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("cartDiscount"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountQueryBuilderDsl.Of())),
                CartDiscountCreatedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
