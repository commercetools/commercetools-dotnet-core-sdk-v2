// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Reviews
{

    public partial class ReviewSetCustomFieldActionQueryBuilderDsl
    {
        public ReviewSetCustomFieldActionQueryBuilderDsl()
        {
        }

        public static ReviewSetCustomFieldActionQueryBuilderDsl Of()
        {
            return new ReviewSetCustomFieldActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ReviewSetCustomFieldActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ReviewSetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ReviewSetCustomFieldActionQueryBuilderDsl>(p, ReviewSetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReviewSetCustomFieldActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<ReviewSetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<ReviewSetCustomFieldActionQueryBuilderDsl>(p, ReviewSetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReviewSetCustomFieldActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<ReviewSetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<ReviewSetCustomFieldActionQueryBuilderDsl>(p, ReviewSetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
