using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderRemoveItemShippingAddressActionQueryBuilderDsl
    {
        public OrderRemoveItemShippingAddressActionQueryBuilderDsl()
        {
        }

        public static OrderRemoveItemShippingAddressActionQueryBuilderDsl Of()
        {
            return new OrderRemoveItemShippingAddressActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderRemoveItemShippingAddressActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderRemoveItemShippingAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderRemoveItemShippingAddressActionQueryBuilderDsl>(p, OrderRemoveItemShippingAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderRemoveItemShippingAddressActionQueryBuilderDsl, string> AddressKey()
        {
            return new ComparisonPredicateBuilder<OrderRemoveItemShippingAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressKey")),
            p => new CombinationQueryPredicate<OrderRemoveItemShippingAddressActionQueryBuilderDsl>(p, OrderRemoveItemShippingAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
