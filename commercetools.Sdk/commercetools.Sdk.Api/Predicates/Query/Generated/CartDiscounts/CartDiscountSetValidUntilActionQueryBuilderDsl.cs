using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CartDiscounts
{

    public partial class CartDiscountSetValidUntilActionQueryBuilderDsl
    {
        public CartDiscountSetValidUntilActionQueryBuilderDsl()
        {
        }

        public static CartDiscountSetValidUntilActionQueryBuilderDsl Of()
        {
            return new CartDiscountSetValidUntilActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartDiscountSetValidUntilActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartDiscountSetValidUntilActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartDiscountSetValidUntilActionQueryBuilderDsl>(p, CartDiscountSetValidUntilActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartDiscountSetValidUntilActionQueryBuilderDsl, DateTime> ValidUntil()
        {
            return new ComparisonPredicateBuilder<CartDiscountSetValidUntilActionQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validUntil")),
            p => new CombinationQueryPredicate<CartDiscountSetValidUntilActionQueryBuilderDsl>(p, CartDiscountSetValidUntilActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
