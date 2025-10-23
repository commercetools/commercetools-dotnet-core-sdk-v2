using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.ReviewRatingStatistics))]
    public partial interface IReviewRatingStatistics
    {
        decimal AverageRating { get; set; }

        decimal HighestRating { get; set; }

        decimal LowestRating { get; set; }

        int Count { get; set; }

        Object RatingsDistribution { get; set; }

    }
}
