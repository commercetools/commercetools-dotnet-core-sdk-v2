using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CartDiscounts
{

    public partial class CartDiscountSetValidFromAndUntilActionQueryBuilderDsl
    {
        public CartDiscountSetValidFromAndUntilActionQueryBuilderDsl()
        {
        }

        public static CartDiscountSetValidFromAndUntilActionQueryBuilderDsl Of()
        {
            return new CartDiscountSetValidFromAndUntilActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartDiscountSetValidFromAndUntilActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartDiscountSetValidFromAndUntilActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartDiscountSetValidFromAndUntilActionQueryBuilderDsl>(p, CartDiscountSetValidFromAndUntilActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartDiscountSetValidFromAndUntilActionQueryBuilderDsl, DateTime> ValidFrom()
        {
            return new ComparisonPredicateBuilder<CartDiscountSetValidFromAndUntilActionQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validFrom")),
            p => new CombinationQueryPredicate<CartDiscountSetValidFromAndUntilActionQueryBuilderDsl>(p, CartDiscountSetValidFromAndUntilActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartDiscountSetValidFromAndUntilActionQueryBuilderDsl, DateTime> ValidUntil()
        {
            return new ComparisonPredicateBuilder<CartDiscountSetValidFromAndUntilActionQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validUntil")),
            p => new CombinationQueryPredicate<CartDiscountSetValidFromAndUntilActionQueryBuilderDsl>(p, CartDiscountSetValidFromAndUntilActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
