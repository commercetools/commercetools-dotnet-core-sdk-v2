using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurringOrders
{

    public partial class RecurringOrderPagedQueryResponseQueryBuilderDsl
    {
        public RecurringOrderPagedQueryResponseQueryBuilderDsl()
        {
        }

        public static RecurringOrderPagedQueryResponseQueryBuilderDsl Of()
        {
            return new RecurringOrderPagedQueryResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurringOrderPagedQueryResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<RecurringOrderPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<RecurringOrderPagedQueryResponseQueryBuilderDsl>(p, RecurringOrderPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurringOrderPagedQueryResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<RecurringOrderPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<RecurringOrderPagedQueryResponseQueryBuilderDsl>(p, RecurringOrderPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurringOrderPagedQueryResponseQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<RecurringOrderPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<RecurringOrderPagedQueryResponseQueryBuilderDsl>(p, RecurringOrderPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurringOrderPagedQueryResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<RecurringOrderPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<RecurringOrderPagedQueryResponseQueryBuilderDsl>(p, RecurringOrderPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<RecurringOrderPagedQueryResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringOrderPagedQueryResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderQueryBuilderDsl.Of())),
                RecurringOrderPagedQueryResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<RecurringOrderPagedQueryResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<RecurringOrderPagedQueryResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<RecurringOrderPagedQueryResponseQueryBuilderDsl>(p, RecurringOrderPagedQueryResponseQueryBuilderDsl.Of));
        }

    }
}
