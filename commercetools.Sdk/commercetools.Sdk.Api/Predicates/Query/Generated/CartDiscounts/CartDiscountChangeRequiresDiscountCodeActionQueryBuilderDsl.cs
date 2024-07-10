using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CartDiscounts
{

    public partial class CartDiscountChangeRequiresDiscountCodeActionQueryBuilderDsl
    {
        public CartDiscountChangeRequiresDiscountCodeActionQueryBuilderDsl()
        {
        }

        public static CartDiscountChangeRequiresDiscountCodeActionQueryBuilderDsl Of()
        {
            return new CartDiscountChangeRequiresDiscountCodeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartDiscountChangeRequiresDiscountCodeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartDiscountChangeRequiresDiscountCodeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartDiscountChangeRequiresDiscountCodeActionQueryBuilderDsl>(p, CartDiscountChangeRequiresDiscountCodeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartDiscountChangeRequiresDiscountCodeActionQueryBuilderDsl, bool> RequiresDiscountCode()
        {
            return new ComparisonPredicateBuilder<CartDiscountChangeRequiresDiscountCodeActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("requiresDiscountCode")),
            p => new CombinationQueryPredicate<CartDiscountChangeRequiresDiscountCodeActionQueryBuilderDsl>(p, CartDiscountChangeRequiresDiscountCodeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
