using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderPagedSearchResponseQueryBuilderDsl
    {
        public OrderPagedSearchResponseQueryBuilderDsl()
        {
        }

        public static OrderPagedSearchResponseQueryBuilderDsl Of()
        {
            return new OrderPagedSearchResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderPagedSearchResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<OrderPagedSearchResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<OrderPagedSearchResponseQueryBuilderDsl>(p, OrderPagedSearchResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderPagedSearchResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<OrderPagedSearchResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<OrderPagedSearchResponseQueryBuilderDsl>(p, OrderPagedSearchResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderPagedSearchResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<OrderPagedSearchResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<OrderPagedSearchResponseQueryBuilderDsl>(p, OrderPagedSearchResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderPagedSearchResponseQueryBuilderDsl> Hits(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.HitQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.HitQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderPagedSearchResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("hits"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.HitQueryBuilderDsl.Of())),
                OrderPagedSearchResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<OrderPagedSearchResponseQueryBuilderDsl> Hits()
        {
            return new CollectionPredicateBuilder<OrderPagedSearchResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("hits")),
                    p => new CombinationQueryPredicate<OrderPagedSearchResponseQueryBuilderDsl>(p, OrderPagedSearchResponseQueryBuilderDsl.Of));
        }

    }
}
