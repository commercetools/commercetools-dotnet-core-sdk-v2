using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CartDiscounts
{

    public partial class CartDiscountLineItemsTargetQueryBuilderDsl
    {
        public CartDiscountLineItemsTargetQueryBuilderDsl()
        {
        }

        public static CartDiscountLineItemsTargetQueryBuilderDsl Of()
        {
            return new CartDiscountLineItemsTargetQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartDiscountLineItemsTargetQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CartDiscountLineItemsTargetQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CartDiscountLineItemsTargetQueryBuilderDsl>(p, CartDiscountLineItemsTargetQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartDiscountLineItemsTargetQueryBuilderDsl, string> Predicate()
        {
            return new ComparisonPredicateBuilder<CartDiscountLineItemsTargetQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("predicate")),
            p => new CombinationQueryPredicate<CartDiscountLineItemsTargetQueryBuilderDsl>(p, CartDiscountLineItemsTargetQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
