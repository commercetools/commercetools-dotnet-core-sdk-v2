using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.States
{

    public partial class StateRemoveRolesActionQueryBuilderDsl
    {
        public StateRemoveRolesActionQueryBuilderDsl()
        {
        }

        public static StateRemoveRolesActionQueryBuilderDsl Of()
        {
            return new StateRemoveRolesActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StateRemoveRolesActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StateRemoveRolesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StateRemoveRolesActionQueryBuilderDsl>(p, StateRemoveRolesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<StateRemoveRolesActionQueryBuilderDsl, string> Roles()
        {
            return new ComparableCollectionPredicateBuilder<StateRemoveRolesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("roles")),
            p => new CombinationQueryPredicate<StateRemoveRolesActionQueryBuilderDsl>(p, StateRemoveRolesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
