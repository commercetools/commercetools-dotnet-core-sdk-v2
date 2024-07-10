using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSetShippingAddressCustomTypeActionQueryBuilderDsl
    {
        public OrderSetShippingAddressCustomTypeActionQueryBuilderDsl()
        {
        }

        public static OrderSetShippingAddressCustomTypeActionQueryBuilderDsl Of()
        {
            return new OrderSetShippingAddressCustomTypeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderSetShippingAddressCustomTypeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderSetShippingAddressCustomTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderSetShippingAddressCustomTypeActionQueryBuilderDsl>(p, OrderSetShippingAddressCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderSetShippingAddressCustomTypeActionQueryBuilderDsl> Type(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSetShippingAddressCustomTypeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("type"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl.Of())),
                OrderSetShippingAddressCustomTypeActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderSetShippingAddressCustomTypeActionQueryBuilderDsl> Fields(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSetShippingAddressCustomTypeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("fields"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl.Of())),
                OrderSetShippingAddressCustomTypeActionQueryBuilderDsl.Of);
        }


    }
}
