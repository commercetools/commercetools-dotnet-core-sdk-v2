using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartRecalculateActionQueryBuilderDsl
    {
        public CartRecalculateActionQueryBuilderDsl()
        {
        }

        public static CartRecalculateActionQueryBuilderDsl Of()
        {
            return new CartRecalculateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartRecalculateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartRecalculateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartRecalculateActionQueryBuilderDsl>(p, CartRecalculateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartRecalculateActionQueryBuilderDsl, bool> UpdateProductData()
        {
            return new ComparisonPredicateBuilder<CartRecalculateActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("updateProductData")),
            p => new CombinationQueryPredicate<CartRecalculateActionQueryBuilderDsl>(p, CartRecalculateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
