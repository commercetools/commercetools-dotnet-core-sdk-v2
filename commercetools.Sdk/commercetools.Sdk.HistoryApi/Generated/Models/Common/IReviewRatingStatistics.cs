using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.ReviewRatingStatistics))]
    public partial interface IReviewRatingStatistics
    {
        int AverageRating { get; set; }

        int HighestRating { get; set; }

        int LowestRating { get; set; }

        int Count { get; set; }

        Object RatingsDistribution { get; set; }

    }
}
