namespace commercetools.Sdk.Api.Models.Reviews
{
    public partial class ReviewSetAuthorNameAction : IReviewSetAuthorNameAction
    {
        public string Action { get; set; }

        public string AuthorName { get; set; }
        public ReviewSetAuthorNameAction()
        {
            this.Action = "setAuthorName";
        }
    }
}
