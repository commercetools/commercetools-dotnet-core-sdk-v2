using System;

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class ReviewRatingStatistics : IReviewRatingStatistics
    {
        public decimal AverageRating { get; set; }

        public decimal HighestRating { get; set; }

        public decimal LowestRating { get; set; }

        public int Count { get; set; }

        public Object RatingsDistribution { get; set; }
    }
}
