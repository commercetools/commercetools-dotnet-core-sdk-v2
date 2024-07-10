using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CartDiscounts
{

    public partial class CartDiscountSetValidFromActionQueryBuilderDsl
    {
        public CartDiscountSetValidFromActionQueryBuilderDsl()
        {
        }

        public static CartDiscountSetValidFromActionQueryBuilderDsl Of()
        {
            return new CartDiscountSetValidFromActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartDiscountSetValidFromActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartDiscountSetValidFromActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartDiscountSetValidFromActionQueryBuilderDsl>(p, CartDiscountSetValidFromActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartDiscountSetValidFromActionQueryBuilderDsl, DateTime> ValidFrom()
        {
            return new ComparisonPredicateBuilder<CartDiscountSetValidFromActionQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validFrom")),
            p => new CombinationQueryPredicate<CartDiscountSetValidFromActionQueryBuilderDsl>(p, CartDiscountSetValidFromActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
