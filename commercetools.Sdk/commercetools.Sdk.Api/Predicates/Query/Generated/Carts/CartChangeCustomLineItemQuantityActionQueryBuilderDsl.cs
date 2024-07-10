using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartChangeCustomLineItemQuantityActionQueryBuilderDsl
    {
        public CartChangeCustomLineItemQuantityActionQueryBuilderDsl()
        {
        }

        public static CartChangeCustomLineItemQuantityActionQueryBuilderDsl Of()
        {
            return new CartChangeCustomLineItemQuantityActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartChangeCustomLineItemQuantityActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartChangeCustomLineItemQuantityActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartChangeCustomLineItemQuantityActionQueryBuilderDsl>(p, CartChangeCustomLineItemQuantityActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartChangeCustomLineItemQuantityActionQueryBuilderDsl, string> CustomLineItemId()
        {
            return new ComparisonPredicateBuilder<CartChangeCustomLineItemQuantityActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItemId")),
            p => new CombinationQueryPredicate<CartChangeCustomLineItemQuantityActionQueryBuilderDsl>(p, CartChangeCustomLineItemQuantityActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartChangeCustomLineItemQuantityActionQueryBuilderDsl, string> CustomLineItemKey()
        {
            return new ComparisonPredicateBuilder<CartChangeCustomLineItemQuantityActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItemKey")),
            p => new CombinationQueryPredicate<CartChangeCustomLineItemQuantityActionQueryBuilderDsl>(p, CartChangeCustomLineItemQuantityActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartChangeCustomLineItemQuantityActionQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<CartChangeCustomLineItemQuantityActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<CartChangeCustomLineItemQuantityActionQueryBuilderDsl>(p, CartChangeCustomLineItemQuantityActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
