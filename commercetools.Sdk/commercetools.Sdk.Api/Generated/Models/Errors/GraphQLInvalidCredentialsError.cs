namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLInvalidCredentialsError : IGraphQLInvalidCredentialsError
    {
        public string Code { get; set; }
        public GraphQLInvalidCredentialsError()
        {
            this.Code = "InvalidCredentials";
        }
    }
}
