using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.States
{

    public partial class StateUpdateActionQueryBuilderDsl
    {
        public StateUpdateActionQueryBuilderDsl()
        {
        }

        public static StateUpdateActionQueryBuilderDsl Of()
        {
            return new StateUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StateUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StateUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StateUpdateActionQueryBuilderDsl>(p, StateUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<StateUpdateActionQueryBuilderDsl> AsAddRoles(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateAddRolesActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateAddRolesActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StateUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateAddRolesActionQueryBuilderDsl.Of()),
                StateUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StateUpdateActionQueryBuilderDsl> AsChangeInitial(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateChangeInitialActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateChangeInitialActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StateUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateChangeInitialActionQueryBuilderDsl.Of()),
                StateUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StateUpdateActionQueryBuilderDsl> AsChangeKey(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateChangeKeyActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateChangeKeyActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StateUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateChangeKeyActionQueryBuilderDsl.Of()),
                StateUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StateUpdateActionQueryBuilderDsl> AsChangeType(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateChangeTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateChangeTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StateUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateChangeTypeActionQueryBuilderDsl.Of()),
                StateUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StateUpdateActionQueryBuilderDsl> AsRemoveRoles(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateRemoveRolesActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateRemoveRolesActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StateUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateRemoveRolesActionQueryBuilderDsl.Of()),
                StateUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StateUpdateActionQueryBuilderDsl> AsSetDescription(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateSetDescriptionActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateSetDescriptionActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StateUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateSetDescriptionActionQueryBuilderDsl.Of()),
                StateUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StateUpdateActionQueryBuilderDsl> AsSetName(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateSetNameActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateSetNameActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StateUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateSetNameActionQueryBuilderDsl.Of()),
                StateUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StateUpdateActionQueryBuilderDsl> AsSetRoles(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateSetRolesActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateSetRolesActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StateUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateSetRolesActionQueryBuilderDsl.Of()),
                StateUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StateUpdateActionQueryBuilderDsl> AsSetTransitions(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateSetTransitionsActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateSetTransitionsActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StateUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateSetTransitionsActionQueryBuilderDsl.Of()),
                StateUpdateActionQueryBuilderDsl.Of);
        }
    }
}
