namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLLineItemQuantityBelowLimitError : IGraphQLLineItemQuantityBelowLimitError
    {
        public string Code { get; set; }

        public int Quantity { get; set; }

        public int MinCartQuantity { get; set; }

        public string LineItem { get; set; }
        public GraphQLLineItemQuantityBelowLimitError()
        {
            this.Code = "LineItemQuantityBelowLimit";
        }
    }
}
