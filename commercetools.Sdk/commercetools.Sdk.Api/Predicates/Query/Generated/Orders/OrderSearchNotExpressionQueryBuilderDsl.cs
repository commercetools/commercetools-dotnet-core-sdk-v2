using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSearchNotExpressionQueryBuilderDsl
    {
        public OrderSearchNotExpressionQueryBuilderDsl()
        {
        }

        public static OrderSearchNotExpressionQueryBuilderDsl Of()
        {
            return new OrderSearchNotExpressionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<OrderSearchNotExpressionQueryBuilderDsl> Not(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchQueryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchQueryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSearchNotExpressionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("not"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchQueryQueryBuilderDsl.Of())),
                OrderSearchNotExpressionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<OrderSearchNotExpressionQueryBuilderDsl> Not()
        {
            return new CollectionPredicateBuilder<OrderSearchNotExpressionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("not")),
                    p => new CombinationQueryPredicate<OrderSearchNotExpressionQueryBuilderDsl>(p, OrderSearchNotExpressionQueryBuilderDsl.Of));
        }

    }
}
