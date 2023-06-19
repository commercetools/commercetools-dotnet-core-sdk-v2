using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSearchFilterExpressionQueryBuilderDsl
    {
        public OrderSearchFilterExpressionQueryBuilderDsl()
        {
        }

        public static OrderSearchFilterExpressionQueryBuilderDsl Of()
        {
            return new OrderSearchFilterExpressionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<OrderSearchFilterExpressionQueryBuilderDsl> Filter(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchQueryExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchQueryExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSearchFilterExpressionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("filter"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchQueryExpressionQueryBuilderDsl.Of())),
                OrderSearchFilterExpressionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<OrderSearchFilterExpressionQueryBuilderDsl> Filter()
        {
            return new CollectionPredicateBuilder<OrderSearchFilterExpressionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("filter")),
                    p => new CombinationQueryPredicate<OrderSearchFilterExpressionQueryBuilderDsl>(p, OrderSearchFilterExpressionQueryBuilderDsl.Of));
        }

    }
}
