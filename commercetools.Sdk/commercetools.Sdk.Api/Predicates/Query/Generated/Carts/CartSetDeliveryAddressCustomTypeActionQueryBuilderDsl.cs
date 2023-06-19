using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartSetDeliveryAddressCustomTypeActionQueryBuilderDsl
    {
        public CartSetDeliveryAddressCustomTypeActionQueryBuilderDsl()
        {
        }

        public static CartSetDeliveryAddressCustomTypeActionQueryBuilderDsl Of()
        {
            return new CartSetDeliveryAddressCustomTypeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartSetDeliveryAddressCustomTypeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartSetDeliveryAddressCustomTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartSetDeliveryAddressCustomTypeActionQueryBuilderDsl>(p, CartSetDeliveryAddressCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartSetDeliveryAddressCustomTypeActionQueryBuilderDsl, string> DeliveryId()
        {
            return new ComparisonPredicateBuilder<CartSetDeliveryAddressCustomTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveryId")),
            p => new CombinationQueryPredicate<CartSetDeliveryAddressCustomTypeActionQueryBuilderDsl>(p, CartSetDeliveryAddressCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartSetDeliveryAddressCustomTypeActionQueryBuilderDsl> Type(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartSetDeliveryAddressCustomTypeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("type"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl.Of())),
                CartSetDeliveryAddressCustomTypeActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CartSetDeliveryAddressCustomTypeActionQueryBuilderDsl> Fields(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartSetDeliveryAddressCustomTypeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("fields"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl.Of())),
                CartSetDeliveryAddressCustomTypeActionQueryBuilderDsl.Of);
        }


    }
}
