// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Reviews
{

    public partial class ReviewSetTargetActionQueryBuilderDsl
    {
        public ReviewSetTargetActionQueryBuilderDsl()
        {
        }

        public static ReviewSetTargetActionQueryBuilderDsl Of()
        {
            return new ReviewSetTargetActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ReviewSetTargetActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ReviewSetTargetActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ReviewSetTargetActionQueryBuilderDsl>(p, ReviewSetTargetActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReviewSetTargetActionQueryBuilderDsl, string> Target()
        {
            return new ComparisonPredicateBuilder<ReviewSetTargetActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("target")),
            p => new CombinationQueryPredicate<ReviewSetTargetActionQueryBuilderDsl>(p, ReviewSetTargetActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
