using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSearchOrExpressionQueryBuilderDsl
    {
        public OrderSearchOrExpressionQueryBuilderDsl()
        {
        }

        public static OrderSearchOrExpressionQueryBuilderDsl Of()
        {
            return new OrderSearchOrExpressionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<OrderSearchOrExpressionQueryBuilderDsl> Or(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchQueryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchQueryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSearchOrExpressionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("or"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchQueryQueryBuilderDsl.Of())),
                OrderSearchOrExpressionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<OrderSearchOrExpressionQueryBuilderDsl> Or()
        {
            return new CollectionPredicateBuilder<OrderSearchOrExpressionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("or")),
                    p => new CombinationQueryPredicate<OrderSearchOrExpressionQueryBuilderDsl>(p, OrderSearchOrExpressionQueryBuilderDsl.Of));
        }

    }
}
