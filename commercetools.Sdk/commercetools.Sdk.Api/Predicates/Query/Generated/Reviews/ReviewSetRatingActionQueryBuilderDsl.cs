using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Reviews
{

    public partial class ReviewSetRatingActionQueryBuilderDsl
    {
        public ReviewSetRatingActionQueryBuilderDsl()
        {
        }

        public static ReviewSetRatingActionQueryBuilderDsl Of()
        {
            return new ReviewSetRatingActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ReviewSetRatingActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ReviewSetRatingActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ReviewSetRatingActionQueryBuilderDsl>(p, ReviewSetRatingActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReviewSetRatingActionQueryBuilderDsl, long> Rating()
        {
            return new ComparisonPredicateBuilder<ReviewSetRatingActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("rating")),
            p => new CombinationQueryPredicate<ReviewSetRatingActionQueryBuilderDsl>(p, ReviewSetRatingActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
