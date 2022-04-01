namespace commercetools.Sdk.Api.Models.Reviews
{
    public partial class ReviewSetTextAction : IReviewSetTextAction
    {
        public string Action { get; set; }

        public string Text { get; set; }
        public ReviewSetTextAction()
        {
            this.Action = "setText";
        }
    }
}
