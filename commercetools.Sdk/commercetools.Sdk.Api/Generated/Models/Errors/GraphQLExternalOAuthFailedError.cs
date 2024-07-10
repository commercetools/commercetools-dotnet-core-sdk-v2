namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLExternalOAuthFailedError : IGraphQLExternalOAuthFailedError
    {
        public string Code { get; set; }
        public GraphQLExternalOAuthFailedError()
        {
            this.Code = "ExternalOAuthFailed";
        }
    }
}
