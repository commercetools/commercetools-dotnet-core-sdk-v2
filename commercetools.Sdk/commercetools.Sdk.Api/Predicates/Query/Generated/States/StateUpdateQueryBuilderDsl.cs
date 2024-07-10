using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.States
{

    public partial class StateUpdateQueryBuilderDsl
    {
        public StateUpdateQueryBuilderDsl()
        {
        }

        public static StateUpdateQueryBuilderDsl Of()
        {
            return new StateUpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StateUpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<StateUpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<StateUpdateQueryBuilderDsl>(p, StateUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StateUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StateUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateUpdateActionQueryBuilderDsl.Of())),
                StateUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StateUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<StateUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<StateUpdateQueryBuilderDsl>(p, StateUpdateQueryBuilderDsl.Of));
        }

    }
}
