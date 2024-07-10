using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSearchWildCardExpressionQueryBuilderDsl
    {
        public OrderSearchWildCardExpressionQueryBuilderDsl()
        {
        }

        public static OrderSearchWildCardExpressionQueryBuilderDsl Of()
        {
            return new OrderSearchWildCardExpressionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<OrderSearchWildCardExpressionQueryBuilderDsl> Wildcard(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchStringValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchStringValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSearchWildCardExpressionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("wildcard"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchStringValueQueryBuilderDsl.Of())),
                OrderSearchWildCardExpressionQueryBuilderDsl.Of);
        }


    }
}
