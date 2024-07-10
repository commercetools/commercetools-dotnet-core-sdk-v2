// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.States
{

    public partial class StateChangeInitialActionQueryBuilderDsl
    {
        public StateChangeInitialActionQueryBuilderDsl()
        {
        }

        public static StateChangeInitialActionQueryBuilderDsl Of()
        {
            return new StateChangeInitialActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StateChangeInitialActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StateChangeInitialActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StateChangeInitialActionQueryBuilderDsl>(p, StateChangeInitialActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StateChangeInitialActionQueryBuilderDsl, bool> Initial()
        {
            return new ComparisonPredicateBuilder<StateChangeInitialActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("initial")),
            p => new CombinationQueryPredicate<StateChangeInitialActionQueryBuilderDsl>(p, StateChangeInitialActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
