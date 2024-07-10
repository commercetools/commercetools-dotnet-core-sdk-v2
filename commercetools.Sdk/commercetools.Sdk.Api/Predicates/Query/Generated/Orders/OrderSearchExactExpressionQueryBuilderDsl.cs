using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSearchExactExpressionQueryBuilderDsl
    {
        public OrderSearchExactExpressionQueryBuilderDsl()
        {
        }

        public static OrderSearchExactExpressionQueryBuilderDsl Of()
        {
            return new OrderSearchExactExpressionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<OrderSearchExactExpressionQueryBuilderDsl> Exact(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchAnyValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchAnyValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSearchExactExpressionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("exact"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchAnyValueQueryBuilderDsl.Of())),
                OrderSearchExactExpressionQueryBuilderDsl.Of);
        }


    }
}
