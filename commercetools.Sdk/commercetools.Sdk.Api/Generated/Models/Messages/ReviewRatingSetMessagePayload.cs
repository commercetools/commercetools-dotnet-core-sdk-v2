using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ReviewRatingSetMessagePayload : IReviewRatingSetMessagePayload
    {
        public string Type { get; set; }

        public decimal? OldRating { get; set; }

        public decimal? NewRating { get; set; }

        public bool IncludedInStatistics { get; set; }

        public IReference Target { get; set; }
        public ReviewRatingSetMessagePayload()
        {
            this.Type = "ReviewRatingSet";
        }
    }
}
