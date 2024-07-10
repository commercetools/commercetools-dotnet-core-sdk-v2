using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSearchQueryQueryBuilderDsl
    {
        public OrderSearchQueryQueryBuilderDsl()
        {
        }

        public static OrderSearchQueryQueryBuilderDsl Of()
        {
            return new OrderSearchQueryQueryBuilderDsl();
        }


        public CombinationQueryPredicate<OrderSearchQueryQueryBuilderDsl> AsOrderSearchCompoundExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchCompoundExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchCompoundExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSearchQueryQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchCompoundExpressionQueryBuilderDsl.Of()),
                OrderSearchQueryQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderSearchQueryQueryBuilderDsl> AsOrderSearchQueryExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchQueryExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchQueryExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSearchQueryQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchQueryExpressionQueryBuilderDsl.Of()),
                OrderSearchQueryQueryBuilderDsl.Of);
        }
    }
}
