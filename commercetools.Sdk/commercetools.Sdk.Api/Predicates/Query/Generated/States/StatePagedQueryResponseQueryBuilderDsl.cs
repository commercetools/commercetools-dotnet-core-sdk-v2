using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.States
{

    public partial class StatePagedQueryResponseQueryBuilderDsl
    {
        public StatePagedQueryResponseQueryBuilderDsl()
        {
        }

        public static StatePagedQueryResponseQueryBuilderDsl Of()
        {
            return new StatePagedQueryResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StatePagedQueryResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<StatePagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<StatePagedQueryResponseQueryBuilderDsl>(p, StatePagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StatePagedQueryResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<StatePagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<StatePagedQueryResponseQueryBuilderDsl>(p, StatePagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StatePagedQueryResponseQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<StatePagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<StatePagedQueryResponseQueryBuilderDsl>(p, StatePagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StatePagedQueryResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<StatePagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<StatePagedQueryResponseQueryBuilderDsl>(p, StatePagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StatePagedQueryResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StatePagedQueryResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateQueryBuilderDsl.Of())),
                StatePagedQueryResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StatePagedQueryResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<StatePagedQueryResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<StatePagedQueryResponseQueryBuilderDsl>(p, StatePagedQueryResponseQueryBuilderDsl.Of));
        }

    }
}
