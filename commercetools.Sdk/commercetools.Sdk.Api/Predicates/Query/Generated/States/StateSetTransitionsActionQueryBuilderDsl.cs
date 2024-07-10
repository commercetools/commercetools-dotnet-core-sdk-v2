using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.States
{

    public partial class StateSetTransitionsActionQueryBuilderDsl
    {
        public StateSetTransitionsActionQueryBuilderDsl()
        {
        }

        public static StateSetTransitionsActionQueryBuilderDsl Of()
        {
            return new StateSetTransitionsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StateSetTransitionsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StateSetTransitionsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StateSetTransitionsActionQueryBuilderDsl>(p, StateSetTransitionsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StateSetTransitionsActionQueryBuilderDsl> Transitions(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StateSetTransitionsActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("transitions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl.Of())),
                StateSetTransitionsActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StateSetTransitionsActionQueryBuilderDsl> Transitions()
        {
            return new CollectionPredicateBuilder<StateSetTransitionsActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("transitions")),
                    p => new CombinationQueryPredicate<StateSetTransitionsActionQueryBuilderDsl>(p, StateSetTransitionsActionQueryBuilderDsl.Of));
        }

    }
}
