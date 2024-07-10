using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartChangeTaxModeActionQueryBuilderDsl
    {
        public CartChangeTaxModeActionQueryBuilderDsl()
        {
        }

        public static CartChangeTaxModeActionQueryBuilderDsl Of()
        {
            return new CartChangeTaxModeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartChangeTaxModeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartChangeTaxModeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartChangeTaxModeActionQueryBuilderDsl>(p, CartChangeTaxModeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartChangeTaxModeActionQueryBuilderDsl, string> TaxMode()
        {
            return new ComparisonPredicateBuilder<CartChangeTaxModeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("taxMode")),
            p => new CombinationQueryPredicate<CartChangeTaxModeActionQueryBuilderDsl>(p, CartChangeTaxModeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
