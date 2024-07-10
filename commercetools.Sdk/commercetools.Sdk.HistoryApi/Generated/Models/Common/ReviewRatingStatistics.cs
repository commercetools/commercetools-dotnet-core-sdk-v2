using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class ReviewRatingStatistics : IReviewRatingStatistics
    {
        public int AverageRating { get; set; }

        public int HighestRating { get; set; }

        public int LowestRating { get; set; }

        public int Count { get; set; }

        public Object RatingsDistribution { get; set; }
    }
}
