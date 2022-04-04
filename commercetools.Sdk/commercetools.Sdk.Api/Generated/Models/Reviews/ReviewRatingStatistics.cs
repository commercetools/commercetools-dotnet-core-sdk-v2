using System;


namespace commercetools.Sdk.Api.Models.Reviews
{
    public partial class ReviewRatingStatistics : IReviewRatingStatistics
    {
        public double AverageRating { get; set; }

        public double HighestRating { get; set; }

        public double LowestRating { get; set; }

        public int Count { get; set; }

        public Object RatingsDistribution { get; set; }
    }
}
