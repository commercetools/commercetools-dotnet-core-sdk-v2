using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSearchPrefixExpressionQueryBuilderDsl
    {
        public OrderSearchPrefixExpressionQueryBuilderDsl()
        {
        }

        public static OrderSearchPrefixExpressionQueryBuilderDsl Of()
        {
            return new OrderSearchPrefixExpressionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<OrderSearchPrefixExpressionQueryBuilderDsl> Prefix(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchStringValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchStringValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSearchPrefixExpressionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("prefix"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchStringValueQueryBuilderDsl.Of())),
                OrderSearchPrefixExpressionQueryBuilderDsl.Of);
        }


    }
}
