using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSearchDateRangeExpressionQueryBuilderDsl
    {
        public OrderSearchDateRangeExpressionQueryBuilderDsl()
        {
        }

        public static OrderSearchDateRangeExpressionQueryBuilderDsl Of()
        {
            return new OrderSearchDateRangeExpressionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<OrderSearchDateRangeExpressionQueryBuilderDsl> Range(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchDateRangeValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchDateRangeValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSearchDateRangeExpressionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("range"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchDateRangeValueQueryBuilderDsl.Of())),
                OrderSearchDateRangeExpressionQueryBuilderDsl.Of);
        }


    }
}
