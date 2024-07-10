using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class OrderEditPagedQueryResponseQueryBuilderDsl
    {
        public OrderEditPagedQueryResponseQueryBuilderDsl()
        {
        }

        public static OrderEditPagedQueryResponseQueryBuilderDsl Of()
        {
            return new OrderEditPagedQueryResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderEditPagedQueryResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<OrderEditPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<OrderEditPagedQueryResponseQueryBuilderDsl>(p, OrderEditPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderEditPagedQueryResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<OrderEditPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<OrderEditPagedQueryResponseQueryBuilderDsl>(p, OrderEditPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderEditPagedQueryResponseQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<OrderEditPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<OrderEditPagedQueryResponseQueryBuilderDsl>(p, OrderEditPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderEditPagedQueryResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<OrderEditPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<OrderEditPagedQueryResponseQueryBuilderDsl>(p, OrderEditPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderEditPagedQueryResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderEditPagedQueryResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditQueryBuilderDsl.Of())),
                OrderEditPagedQueryResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<OrderEditPagedQueryResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<OrderEditPagedQueryResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<OrderEditPagedQueryResponseQueryBuilderDsl>(p, OrderEditPagedQueryResponseQueryBuilderDsl.Of));
        }

    }
}
