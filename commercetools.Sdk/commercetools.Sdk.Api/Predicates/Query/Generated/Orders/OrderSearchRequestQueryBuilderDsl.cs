using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSearchRequestQueryBuilderDsl
    {
        public OrderSearchRequestQueryBuilderDsl()
        {
        }

        public static OrderSearchRequestQueryBuilderDsl Of()
        {
            return new OrderSearchRequestQueryBuilderDsl();
        }

        public CombinationQueryPredicate<OrderSearchRequestQueryBuilderDsl> Query(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchQueryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchQueryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSearchRequestQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("query"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchQueryQueryBuilderDsl.Of())),
                OrderSearchRequestQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderSearchRequestQueryBuilderDsl> Sort(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchSortingQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchSortingQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSearchRequestQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("sort"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchSortingQueryBuilderDsl.Of())),
                OrderSearchRequestQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<OrderSearchRequestQueryBuilderDsl> Sort()
        {
            return new CollectionPredicateBuilder<OrderSearchRequestQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sort")),
                    p => new CombinationQueryPredicate<OrderSearchRequestQueryBuilderDsl>(p, OrderSearchRequestQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<OrderSearchRequestQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<OrderSearchRequestQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<OrderSearchRequestQueryBuilderDsl>(p, OrderSearchRequestQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSearchRequestQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<OrderSearchRequestQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<OrderSearchRequestQueryBuilderDsl>(p, OrderSearchRequestQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
