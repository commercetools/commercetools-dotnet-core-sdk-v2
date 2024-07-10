// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Reviews
{

    public partial class ReviewSetTitleActionQueryBuilderDsl
    {
        public ReviewSetTitleActionQueryBuilderDsl()
        {
        }

        public static ReviewSetTitleActionQueryBuilderDsl Of()
        {
            return new ReviewSetTitleActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ReviewSetTitleActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ReviewSetTitleActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ReviewSetTitleActionQueryBuilderDsl>(p, ReviewSetTitleActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReviewSetTitleActionQueryBuilderDsl, string> Title()
        {
            return new ComparisonPredicateBuilder<ReviewSetTitleActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("title")),
            p => new CombinationQueryPredicate<ReviewSetTitleActionQueryBuilderDsl>(p, ReviewSetTitleActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
