using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartSetBillingAddressCustomTypeActionQueryBuilderDsl
    {
        public CartSetBillingAddressCustomTypeActionQueryBuilderDsl()
        {
        }

        public static CartSetBillingAddressCustomTypeActionQueryBuilderDsl Of()
        {
            return new CartSetBillingAddressCustomTypeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartSetBillingAddressCustomTypeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartSetBillingAddressCustomTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartSetBillingAddressCustomTypeActionQueryBuilderDsl>(p, CartSetBillingAddressCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartSetBillingAddressCustomTypeActionQueryBuilderDsl> Type(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartSetBillingAddressCustomTypeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("type"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl.Of())),
                CartSetBillingAddressCustomTypeActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CartSetBillingAddressCustomTypeActionQueryBuilderDsl> Fields(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartSetBillingAddressCustomTypeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("fields"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl.Of())),
                CartSetBillingAddressCustomTypeActionQueryBuilderDsl.Of);
        }


    }
}
