using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSearchSortingQueryBuilderDsl
    {
        public OrderSearchSortingQueryBuilderDsl()
        {
        }

        public static OrderSearchSortingQueryBuilderDsl Of()
        {
            return new OrderSearchSortingQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderSearchSortingQueryBuilderDsl, string> Field()
        {
            return new ComparisonPredicateBuilder<OrderSearchSortingQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("field")),
            p => new CombinationQueryPredicate<OrderSearchSortingQueryBuilderDsl>(p, OrderSearchSortingQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSearchSortingQueryBuilderDsl, string> Language()
        {
            return new ComparisonPredicateBuilder<OrderSearchSortingQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("language")),
            p => new CombinationQueryPredicate<OrderSearchSortingQueryBuilderDsl>(p, OrderSearchSortingQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSearchSortingQueryBuilderDsl, string> Order()
        {
            return new ComparisonPredicateBuilder<OrderSearchSortingQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("order")),
            p => new CombinationQueryPredicate<OrderSearchSortingQueryBuilderDsl>(p, OrderSearchSortingQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSearchSortingQueryBuilderDsl, string> Mode()
        {
            return new ComparisonPredicateBuilder<OrderSearchSortingQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("mode")),
            p => new CombinationQueryPredicate<OrderSearchSortingQueryBuilderDsl>(p, OrderSearchSortingQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderSearchSortingQueryBuilderDsl> Filter(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchQueryExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchQueryExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSearchSortingQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("filter"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchQueryExpressionQueryBuilderDsl.Of())),
                OrderSearchSortingQueryBuilderDsl.Of);
        }


    }
}
