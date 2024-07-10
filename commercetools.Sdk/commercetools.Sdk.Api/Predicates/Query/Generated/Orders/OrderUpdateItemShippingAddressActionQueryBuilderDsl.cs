using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderUpdateItemShippingAddressActionQueryBuilderDsl
    {
        public OrderUpdateItemShippingAddressActionQueryBuilderDsl()
        {
        }

        public static OrderUpdateItemShippingAddressActionQueryBuilderDsl Of()
        {
            return new OrderUpdateItemShippingAddressActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderUpdateItemShippingAddressActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderUpdateItemShippingAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderUpdateItemShippingAddressActionQueryBuilderDsl>(p, OrderUpdateItemShippingAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderUpdateItemShippingAddressActionQueryBuilderDsl> Address(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateItemShippingAddressActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("address"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl.Of())),
                OrderUpdateItemShippingAddressActionQueryBuilderDsl.Of);
        }


    }
}
