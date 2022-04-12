using commercetools.Sdk.Api.Models.Common;


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
