using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSearchFullTextExpressionQueryBuilderDsl
    {
        public OrderSearchFullTextExpressionQueryBuilderDsl()
        {
        }

        public static OrderSearchFullTextExpressionQueryBuilderDsl Of()
        {
            return new OrderSearchFullTextExpressionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<OrderSearchFullTextExpressionQueryBuilderDsl> FullText(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchFullTextValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchFullTextValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSearchFullTextExpressionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("fullText"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchFullTextValueQueryBuilderDsl.Of())),
                OrderSearchFullTextExpressionQueryBuilderDsl.Of);
        }


    }
}
