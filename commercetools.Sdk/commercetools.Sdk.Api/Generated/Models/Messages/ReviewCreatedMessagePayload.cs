using commercetools.Sdk.Api.Models.Reviews;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ReviewCreatedMessagePayload : IReviewCreatedMessagePayload
    {
        public string Type { get; set; }

        public IReview Review { get; set; }
        public ReviewCreatedMessagePayload()
        {
            this.Type = "ReviewCreated";
        }
    }
}
