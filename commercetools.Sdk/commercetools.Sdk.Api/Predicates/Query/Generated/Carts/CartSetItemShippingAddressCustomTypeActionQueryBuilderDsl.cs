using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartSetItemShippingAddressCustomTypeActionQueryBuilderDsl
    {
        public CartSetItemShippingAddressCustomTypeActionQueryBuilderDsl()
        {
        }

        public static CartSetItemShippingAddressCustomTypeActionQueryBuilderDsl Of()
        {
            return new CartSetItemShippingAddressCustomTypeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartSetItemShippingAddressCustomTypeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartSetItemShippingAddressCustomTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartSetItemShippingAddressCustomTypeActionQueryBuilderDsl>(p, CartSetItemShippingAddressCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartSetItemShippingAddressCustomTypeActionQueryBuilderDsl, string> AddressKey()
        {
            return new ComparisonPredicateBuilder<CartSetItemShippingAddressCustomTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressKey")),
            p => new CombinationQueryPredicate<CartSetItemShippingAddressCustomTypeActionQueryBuilderDsl>(p, CartSetItemShippingAddressCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartSetItemShippingAddressCustomTypeActionQueryBuilderDsl> Type(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartSetItemShippingAddressCustomTypeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("type"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl.Of())),
                CartSetItemShippingAddressCustomTypeActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CartSetItemShippingAddressCustomTypeActionQueryBuilderDsl> Fields(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartSetItemShippingAddressCustomTypeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("fields"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl.Of())),
                CartSetItemShippingAddressCustomTypeActionQueryBuilderDsl.Of);
        }


    }
}
