using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderUpdateQueryBuilderDsl
    {
        public OrderUpdateQueryBuilderDsl()
        {
        }

        public static OrderUpdateQueryBuilderDsl Of()
        {
            return new OrderUpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderUpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<OrderUpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<OrderUpdateQueryBuilderDsl>(p, OrderUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderUpdateActionQueryBuilderDsl.Of())),
                OrderUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<OrderUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<OrderUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<OrderUpdateQueryBuilderDsl>(p, OrderUpdateQueryBuilderDsl.Of));
        }

    }
}
