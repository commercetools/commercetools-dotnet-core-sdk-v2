namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLBadGatewayError : IGraphQLBadGatewayError
    {
        public string Code { get; set; }
        public GraphQLBadGatewayError()
        {
            this.Code = "BadGateway";
        }
    }
}
