using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSearchNumberRangeExpressionQueryBuilderDsl
    {
        public OrderSearchNumberRangeExpressionQueryBuilderDsl()
        {
        }

        public static OrderSearchNumberRangeExpressionQueryBuilderDsl Of()
        {
            return new OrderSearchNumberRangeExpressionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<OrderSearchNumberRangeExpressionQueryBuilderDsl> Range(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchNumberRangeValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchNumberRangeValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSearchNumberRangeExpressionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("range"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchNumberRangeValueQueryBuilderDsl.Of())),
                OrderSearchNumberRangeExpressionQueryBuilderDsl.Of);
        }


    }
}
