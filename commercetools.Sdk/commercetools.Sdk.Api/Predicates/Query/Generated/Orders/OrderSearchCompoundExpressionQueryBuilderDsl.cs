using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSearchCompoundExpressionQueryBuilderDsl
    {
        public OrderSearchCompoundExpressionQueryBuilderDsl()
        {
        }

        public static OrderSearchCompoundExpressionQueryBuilderDsl Of()
        {
            return new OrderSearchCompoundExpressionQueryBuilderDsl();
        }


        public CombinationQueryPredicate<OrderSearchCompoundExpressionQueryBuilderDsl> AsOrderSearchAndExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchAndExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchAndExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSearchCompoundExpressionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchAndExpressionQueryBuilderDsl.Of()),
                OrderSearchCompoundExpressionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderSearchCompoundExpressionQueryBuilderDsl> AsOrderSearchFilterExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchFilterExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchFilterExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSearchCompoundExpressionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchFilterExpressionQueryBuilderDsl.Of()),
                OrderSearchCompoundExpressionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderSearchCompoundExpressionQueryBuilderDsl> AsOrderSearchNotExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchNotExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchNotExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSearchCompoundExpressionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchNotExpressionQueryBuilderDsl.Of()),
                OrderSearchCompoundExpressionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderSearchCompoundExpressionQueryBuilderDsl> AsOrderSearchOrExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchOrExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchOrExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSearchCompoundExpressionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchOrExpressionQueryBuilderDsl.Of()),
                OrderSearchCompoundExpressionQueryBuilderDsl.Of);
        }
    }
}
