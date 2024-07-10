using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.States
{

    public partial class StateSetRolesActionQueryBuilderDsl
    {
        public StateSetRolesActionQueryBuilderDsl()
        {
        }

        public static StateSetRolesActionQueryBuilderDsl Of()
        {
            return new StateSetRolesActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StateSetRolesActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StateSetRolesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StateSetRolesActionQueryBuilderDsl>(p, StateSetRolesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<StateSetRolesActionQueryBuilderDsl, string> Roles()
        {
            return new ComparableCollectionPredicateBuilder<StateSetRolesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("roles")),
            p => new CombinationQueryPredicate<StateSetRolesActionQueryBuilderDsl>(p, StateSetRolesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
