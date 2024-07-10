using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSearchExistsExpressionQueryBuilderDsl
    {
        public OrderSearchExistsExpressionQueryBuilderDsl()
        {
        }

        public static OrderSearchExistsExpressionQueryBuilderDsl Of()
        {
            return new OrderSearchExistsExpressionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<OrderSearchExistsExpressionQueryBuilderDsl> Exists(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchQueryExpressionValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchQueryExpressionValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSearchExistsExpressionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("exists"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchQueryExpressionValueQueryBuilderDsl.Of())),
                OrderSearchExistsExpressionQueryBuilderDsl.Of);
        }


    }
}
