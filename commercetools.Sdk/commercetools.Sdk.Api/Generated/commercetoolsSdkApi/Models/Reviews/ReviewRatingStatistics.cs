using System;

namespace commercetools.Sdk.Api.Models.Reviews
{

    public partial class ReviewRatingStatistics : IReviewRatingStatistics
    {
        public decimal AverageRating { get; set; }

        public int HighestRating { get; set; }

        public int LowestRating { get; set; }

        public long Count { get; set; }

        public Object RatingsDistribution { get; set; }
    }
}
