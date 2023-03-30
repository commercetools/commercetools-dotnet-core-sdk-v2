namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLInvalidItemShippingDetailsError : IGraphQLInvalidItemShippingDetailsError
    {
        public string Code { get; set; }

        public string Subject { get; set; }

        public string ItemId { get; set; }
        public GraphQLInvalidItemShippingDetailsError()
        {
            this.Code = "InvalidItemShippingDetails";
        }
    }
}
