namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class OrderEditSetCommentAction : IOrderEditSetCommentAction
    {
        public string Action { get; set; }

        public string Comment { get; set; }
        public OrderEditSetCommentAction()
        {
            this.Action = "setComment";
        }
    }
}
