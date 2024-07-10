using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Reviews
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
