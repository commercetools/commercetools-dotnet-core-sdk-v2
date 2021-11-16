using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Messages
{
    public partial class ReviewRatingSetMessagePayload : IReviewRatingSetMessagePayload
    {
        public string Type { get; set; }

        public double? OldRating { get; set; }

        public double? NewRating { get; set; }

        public bool IncludedInStatistics { get; set; }

        public IReference Target { get; set; }
        public ReviewRatingSetMessagePayload()
        {
            this.Type = "ReviewRatingSet";
        }
    }
}
