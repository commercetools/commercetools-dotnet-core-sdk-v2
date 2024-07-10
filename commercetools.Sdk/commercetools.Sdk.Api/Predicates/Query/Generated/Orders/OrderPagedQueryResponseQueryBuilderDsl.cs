using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderPagedQueryResponseQueryBuilderDsl
    {
        public OrderPagedQueryResponseQueryBuilderDsl()
        {
        }

        public static OrderPagedQueryResponseQueryBuilderDsl Of()
        {
            return new OrderPagedQueryResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderPagedQueryResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<OrderPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<OrderPagedQueryResponseQueryBuilderDsl>(p, OrderPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderPagedQueryResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<OrderPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<OrderPagedQueryResponseQueryBuilderDsl>(p, OrderPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderPagedQueryResponseQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<OrderPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<OrderPagedQueryResponseQueryBuilderDsl>(p, OrderPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderPagedQueryResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<OrderPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<OrderPagedQueryResponseQueryBuilderDsl>(p, OrderPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderPagedQueryResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderPagedQueryResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderQueryBuilderDsl.Of())),
                OrderPagedQueryResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<OrderPagedQueryResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<OrderPagedQueryResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<OrderPagedQueryResponseQueryBuilderDsl>(p, OrderPagedQueryResponseQueryBuilderDsl.Of));
        }

    }
}
