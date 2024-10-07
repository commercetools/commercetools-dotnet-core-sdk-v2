

namespace commercetools.Sdk.Api.Models.Reviews
{

    public partial class ReviewSetRatingAction : IReviewSetRatingAction
    {
        public string Action { get; set; }

        public int? Rating { get; set; }
        public ReviewSetRatingAction()
        {
            this.Action = "setRating";
        }
    }
}
