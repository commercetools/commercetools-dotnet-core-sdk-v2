namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLLineItemQuantityAboveLimitError : IGraphQLLineItemQuantityAboveLimitError
    {
        public string Code { get; set; }

        public int Quantity { get; set; }

        public int MaxCartQuantity { get; set; }

        public string LineItem { get; set; }
        public GraphQLLineItemQuantityAboveLimitError()
        {
            this.Code = "LineItemQuantityAboveLimit";
        }
    }
}
