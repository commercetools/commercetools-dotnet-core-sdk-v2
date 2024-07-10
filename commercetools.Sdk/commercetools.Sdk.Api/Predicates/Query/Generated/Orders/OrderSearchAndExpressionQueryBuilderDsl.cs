using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSearchAndExpressionQueryBuilderDsl
    {
        public OrderSearchAndExpressionQueryBuilderDsl()
        {
        }

        public static OrderSearchAndExpressionQueryBuilderDsl Of()
        {
            return new OrderSearchAndExpressionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<OrderSearchAndExpressionQueryBuilderDsl> And(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchQueryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchQueryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSearchAndExpressionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("and"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchQueryQueryBuilderDsl.Of())),
                OrderSearchAndExpressionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<OrderSearchAndExpressionQueryBuilderDsl> And()
        {
            return new CollectionPredicateBuilder<OrderSearchAndExpressionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("and")),
                    p => new CombinationQueryPredicate<OrderSearchAndExpressionQueryBuilderDsl>(p, OrderSearchAndExpressionQueryBuilderDsl.Of));
        }

    }
}
