using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Reviews
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Reviews.ReviewRatingStatistics))]
    public partial interface IReviewRatingStatistics
    {
        double AverageRating { get; set; }

        double HighestRating { get; set; }

        double LowestRating { get; set; }

        int Count { get; set; }

        Object RatingsDistribution { get; set; }
    }
}
