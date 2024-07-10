using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CartDiscounts
{

    public partial class CartDiscountSetKeyActionQueryBuilderDsl
    {
        public CartDiscountSetKeyActionQueryBuilderDsl()
        {
        }

        public static CartDiscountSetKeyActionQueryBuilderDsl Of()
        {
            return new CartDiscountSetKeyActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartDiscountSetKeyActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartDiscountSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartDiscountSetKeyActionQueryBuilderDsl>(p, CartDiscountSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartDiscountSetKeyActionQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<CartDiscountSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<CartDiscountSetKeyActionQueryBuilderDsl>(p, CartDiscountSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
