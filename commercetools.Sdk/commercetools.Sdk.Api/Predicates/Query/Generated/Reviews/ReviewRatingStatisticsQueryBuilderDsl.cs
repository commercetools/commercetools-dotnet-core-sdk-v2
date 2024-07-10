using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Reviews
{

    public partial class ReviewRatingStatisticsQueryBuilderDsl
    {
        public ReviewRatingStatisticsQueryBuilderDsl()
        {
        }

        public static ReviewRatingStatisticsQueryBuilderDsl Of()
        {
            return new ReviewRatingStatisticsQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ReviewRatingStatisticsQueryBuilderDsl, decimal> AverageRating()
        {
            return new ComparisonPredicateBuilder<ReviewRatingStatisticsQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("averageRating")),
            p => new CombinationQueryPredicate<ReviewRatingStatisticsQueryBuilderDsl>(p, ReviewRatingStatisticsQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReviewRatingStatisticsQueryBuilderDsl, decimal> HighestRating()
        {
            return new ComparisonPredicateBuilder<ReviewRatingStatisticsQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("highestRating")),
            p => new CombinationQueryPredicate<ReviewRatingStatisticsQueryBuilderDsl>(p, ReviewRatingStatisticsQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReviewRatingStatisticsQueryBuilderDsl, decimal> LowestRating()
        {
            return new ComparisonPredicateBuilder<ReviewRatingStatisticsQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lowestRating")),
            p => new CombinationQueryPredicate<ReviewRatingStatisticsQueryBuilderDsl>(p, ReviewRatingStatisticsQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReviewRatingStatisticsQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<ReviewRatingStatisticsQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<ReviewRatingStatisticsQueryBuilderDsl>(p, ReviewRatingStatisticsQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReviewRatingStatisticsQueryBuilderDsl, string> RatingsDistribution()
        {
            return new ComparisonPredicateBuilder<ReviewRatingStatisticsQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("ratingsDistribution")),
            p => new CombinationQueryPredicate<ReviewRatingStatisticsQueryBuilderDsl>(p, ReviewRatingStatisticsQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
