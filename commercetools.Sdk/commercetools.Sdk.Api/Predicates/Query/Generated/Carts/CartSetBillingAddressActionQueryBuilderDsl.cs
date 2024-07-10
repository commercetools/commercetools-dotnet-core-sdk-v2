using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartSetBillingAddressActionQueryBuilderDsl
    {
        public CartSetBillingAddressActionQueryBuilderDsl()
        {
        }

        public static CartSetBillingAddressActionQueryBuilderDsl Of()
        {
            return new CartSetBillingAddressActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartSetBillingAddressActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartSetBillingAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartSetBillingAddressActionQueryBuilderDsl>(p, CartSetBillingAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartSetBillingAddressActionQueryBuilderDsl> Address(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartSetBillingAddressActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("address"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl.Of())),
                CartSetBillingAddressActionQueryBuilderDsl.Of);
        }


    }
}
