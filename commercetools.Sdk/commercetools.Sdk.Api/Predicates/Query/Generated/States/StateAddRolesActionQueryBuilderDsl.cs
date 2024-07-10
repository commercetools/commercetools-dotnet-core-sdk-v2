// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.States
{

    public partial class StateAddRolesActionQueryBuilderDsl
    {
        public StateAddRolesActionQueryBuilderDsl()
        {
        }

        public static StateAddRolesActionQueryBuilderDsl Of()
        {
            return new StateAddRolesActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StateAddRolesActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StateAddRolesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StateAddRolesActionQueryBuilderDsl>(p, StateAddRolesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<StateAddRolesActionQueryBuilderDsl, string> Roles()
        {
            return new ComparableCollectionPredicateBuilder<StateAddRolesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("roles")),
            p => new CombinationQueryPredicate<StateAddRolesActionQueryBuilderDsl>(p, StateAddRolesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
