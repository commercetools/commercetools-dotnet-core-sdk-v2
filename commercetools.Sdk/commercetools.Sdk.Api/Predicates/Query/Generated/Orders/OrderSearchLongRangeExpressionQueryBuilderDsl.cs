using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSearchLongRangeExpressionQueryBuilderDsl
    {
        public OrderSearchLongRangeExpressionQueryBuilderDsl()
        {
        }

        public static OrderSearchLongRangeExpressionQueryBuilderDsl Of()
        {
            return new OrderSearchLongRangeExpressionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<OrderSearchLongRangeExpressionQueryBuilderDsl> Range(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchLongRangeValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchLongRangeValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSearchLongRangeExpressionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("range"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchLongRangeValueQueryBuilderDsl.Of())),
                OrderSearchLongRangeExpressionQueryBuilderDsl.Of);
        }


    }
}
