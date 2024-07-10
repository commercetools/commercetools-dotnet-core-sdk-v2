namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLInvalidTokenError : IGraphQLInvalidTokenError
    {
        public string Code { get; set; }
        public GraphQLInvalidTokenError()
        {
            this.Code = "invalid_token";
        }
    }
}
