using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Reviews
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Reviews.ReviewRatingStatistics))]
    public partial interface IReviewRatingStatistics
    {
        decimal AverageRating { get; set; }

        int HighestRating { get; set; }

        int LowestRating { get; set; }

        long Count { get; set; }

        Object RatingsDistribution { get; set; }

    }
}
