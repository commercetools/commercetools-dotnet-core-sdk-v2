using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Reviews
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Reviews.ReviewRatingStatistics))]
    public partial interface IReviewRatingStatistics
    {
        decimal AverageRating { get; set; }

        decimal HighestRating { get; set; }

        decimal LowestRating { get; set; }

        int Count { get; set; }

        Object RatingsDistribution { get; set; }

    }
}
