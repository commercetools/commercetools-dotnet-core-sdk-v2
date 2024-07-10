using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartSetCustomerIdActionQueryBuilderDsl
    {
        public CartSetCustomerIdActionQueryBuilderDsl()
        {
        }

        public static CartSetCustomerIdActionQueryBuilderDsl Of()
        {
            return new CartSetCustomerIdActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartSetCustomerIdActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartSetCustomerIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartSetCustomerIdActionQueryBuilderDsl>(p, CartSetCustomerIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartSetCustomerIdActionQueryBuilderDsl, string> CustomerId()
        {
            return new ComparisonPredicateBuilder<CartSetCustomerIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customerId")),
            p => new CombinationQueryPredicate<CartSetCustomerIdActionQueryBuilderDsl>(p, CartSetCustomerIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
