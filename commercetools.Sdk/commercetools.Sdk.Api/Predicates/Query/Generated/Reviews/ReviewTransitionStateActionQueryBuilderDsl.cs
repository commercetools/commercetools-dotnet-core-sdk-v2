using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Reviews
{

    public partial class ReviewTransitionStateActionQueryBuilderDsl
    {
        public ReviewTransitionStateActionQueryBuilderDsl()
        {
        }

        public static ReviewTransitionStateActionQueryBuilderDsl Of()
        {
            return new ReviewTransitionStateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ReviewTransitionStateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ReviewTransitionStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ReviewTransitionStateActionQueryBuilderDsl>(p, ReviewTransitionStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ReviewTransitionStateActionQueryBuilderDsl> State(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReviewTransitionStateActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("state"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl.Of())),
                ReviewTransitionStateActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ReviewTransitionStateActionQueryBuilderDsl, bool> Force()
        {
            return new ComparisonPredicateBuilder<ReviewTransitionStateActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("force")),
            p => new CombinationQueryPredicate<ReviewTransitionStateActionQueryBuilderDsl>(p, ReviewTransitionStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
