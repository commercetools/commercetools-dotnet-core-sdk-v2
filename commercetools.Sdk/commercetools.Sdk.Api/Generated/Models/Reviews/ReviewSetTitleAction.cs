namespace commercetools.Sdk.Api.Models.Reviews
{
    public partial class ReviewSetTitleAction : IReviewSetTitleAction
    {
        public string Action { get; set; }

        public string Title { get; set; }
        public ReviewSetTitleAction()
        {
            this.Action = "setTitle";
        }
    }
}
