using commercetools.Api.Models.Reviews;


namespace commercetools.Api.Models.Messages
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
