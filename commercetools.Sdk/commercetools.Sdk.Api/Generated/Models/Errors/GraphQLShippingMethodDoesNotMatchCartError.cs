namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLShippingMethodDoesNotMatchCartError : IGraphQLShippingMethodDoesNotMatchCartError
    {
        public string Code { get; set; }
        public GraphQLShippingMethodDoesNotMatchCartError()
        {
            this.Code = "ShippingMethodDoesNotMatchCart";
        }
    }
}
