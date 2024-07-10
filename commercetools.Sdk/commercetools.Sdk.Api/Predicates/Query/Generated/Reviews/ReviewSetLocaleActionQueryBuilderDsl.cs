// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Reviews
{

    public partial class ReviewSetLocaleActionQueryBuilderDsl
    {
        public ReviewSetLocaleActionQueryBuilderDsl()
        {
        }

        public static ReviewSetLocaleActionQueryBuilderDsl Of()
        {
            return new ReviewSetLocaleActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ReviewSetLocaleActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ReviewSetLocaleActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ReviewSetLocaleActionQueryBuilderDsl>(p, ReviewSetLocaleActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReviewSetLocaleActionQueryBuilderDsl, string> Locale()
        {
            return new ComparisonPredicateBuilder<ReviewSetLocaleActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("locale")),
            p => new CombinationQueryPredicate<ReviewSetLocaleActionQueryBuilderDsl>(p, ReviewSetLocaleActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
