using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSearchQueryExpressionQueryBuilderDsl
    {
        public OrderSearchQueryExpressionQueryBuilderDsl()
        {
        }

        public static OrderSearchQueryExpressionQueryBuilderDsl Of()
        {
            return new OrderSearchQueryExpressionQueryBuilderDsl();
        }


        public CombinationQueryPredicate<OrderSearchQueryExpressionQueryBuilderDsl> AsOrderSearchDateRangeExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchDateRangeExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchDateRangeExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSearchQueryExpressionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchDateRangeExpressionQueryBuilderDsl.Of()),
                OrderSearchQueryExpressionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderSearchQueryExpressionQueryBuilderDsl> AsOrderSearchExactExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchExactExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchExactExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSearchQueryExpressionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchExactExpressionQueryBuilderDsl.Of()),
                OrderSearchQueryExpressionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderSearchQueryExpressionQueryBuilderDsl> AsOrderSearchExistsExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchExistsExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchExistsExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSearchQueryExpressionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchExistsExpressionQueryBuilderDsl.Of()),
                OrderSearchQueryExpressionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderSearchQueryExpressionQueryBuilderDsl> AsOrderSearchFullTextExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchFullTextExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchFullTextExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSearchQueryExpressionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchFullTextExpressionQueryBuilderDsl.Of()),
                OrderSearchQueryExpressionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderSearchQueryExpressionQueryBuilderDsl> AsOrderSearchLongRangeExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchLongRangeExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchLongRangeExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSearchQueryExpressionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchLongRangeExpressionQueryBuilderDsl.Of()),
                OrderSearchQueryExpressionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderSearchQueryExpressionQueryBuilderDsl> AsOrderSearchNumberRangeExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchNumberRangeExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchNumberRangeExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSearchQueryExpressionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchNumberRangeExpressionQueryBuilderDsl.Of()),
                OrderSearchQueryExpressionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderSearchQueryExpressionQueryBuilderDsl> AsOrderSearchPrefixExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchPrefixExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchPrefixExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSearchQueryExpressionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchPrefixExpressionQueryBuilderDsl.Of()),
                OrderSearchQueryExpressionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderSearchQueryExpressionQueryBuilderDsl> AsOrderSearchWildCardExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchWildCardExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchWildCardExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSearchQueryExpressionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchWildCardExpressionQueryBuilderDsl.Of()),
                OrderSearchQueryExpressionQueryBuilderDsl.Of);
        }
    }
}
