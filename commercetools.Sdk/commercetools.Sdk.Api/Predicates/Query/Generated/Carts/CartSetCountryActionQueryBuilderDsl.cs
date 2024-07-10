using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartSetCountryActionQueryBuilderDsl
    {
        public CartSetCountryActionQueryBuilderDsl()
        {
        }

        public static CartSetCountryActionQueryBuilderDsl Of()
        {
            return new CartSetCountryActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartSetCountryActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartSetCountryActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartSetCountryActionQueryBuilderDsl>(p, CartSetCountryActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartSetCountryActionQueryBuilderDsl, string> Country()
        {
            return new ComparisonPredicateBuilder<CartSetCountryActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("country")),
            p => new CombinationQueryPredicate<CartSetCountryActionQueryBuilderDsl>(p, CartSetCountryActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
