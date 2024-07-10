using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSetShippingAddressActionQueryBuilderDsl
    {
        public OrderSetShippingAddressActionQueryBuilderDsl()
        {
        }

        public static OrderSetShippingAddressActionQueryBuilderDsl Of()
        {
            return new OrderSetShippingAddressActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderSetShippingAddressActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderSetShippingAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderSetShippingAddressActionQueryBuilderDsl>(p, OrderSetShippingAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderSetShippingAddressActionQueryBuilderDsl> Address(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSetShippingAddressActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("address"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl.Of())),
                OrderSetShippingAddressActionQueryBuilderDsl.Of);
        }


    }
}
