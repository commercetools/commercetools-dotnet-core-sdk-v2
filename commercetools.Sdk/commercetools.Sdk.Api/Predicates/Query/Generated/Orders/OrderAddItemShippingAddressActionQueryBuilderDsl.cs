using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderAddItemShippingAddressActionQueryBuilderDsl
    {
        public OrderAddItemShippingAddressActionQueryBuilderDsl()
        {
        }

        public static OrderAddItemShippingAddressActionQueryBuilderDsl Of()
        {
            return new OrderAddItemShippingAddressActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderAddItemShippingAddressActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderAddItemShippingAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderAddItemShippingAddressActionQueryBuilderDsl>(p, OrderAddItemShippingAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderAddItemShippingAddressActionQueryBuilderDsl> Address(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderAddItemShippingAddressActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("address"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl.Of())),
                OrderAddItemShippingAddressActionQueryBuilderDsl.Of);
        }


    }
}
