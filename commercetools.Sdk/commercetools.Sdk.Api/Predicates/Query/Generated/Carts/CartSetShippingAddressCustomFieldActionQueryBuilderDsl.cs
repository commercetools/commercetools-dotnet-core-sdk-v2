using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartSetShippingAddressCustomFieldActionQueryBuilderDsl
    {
        public CartSetShippingAddressCustomFieldActionQueryBuilderDsl()
        {
        }

        public static CartSetShippingAddressCustomFieldActionQueryBuilderDsl Of()
        {
            return new CartSetShippingAddressCustomFieldActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartSetShippingAddressCustomFieldActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartSetShippingAddressCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartSetShippingAddressCustomFieldActionQueryBuilderDsl>(p, CartSetShippingAddressCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartSetShippingAddressCustomFieldActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<CartSetShippingAddressCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<CartSetShippingAddressCustomFieldActionQueryBuilderDsl>(p, CartSetShippingAddressCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartSetShippingAddressCustomFieldActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<CartSetShippingAddressCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<CartSetShippingAddressCustomFieldActionQueryBuilderDsl>(p, CartSetShippingAddressCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
