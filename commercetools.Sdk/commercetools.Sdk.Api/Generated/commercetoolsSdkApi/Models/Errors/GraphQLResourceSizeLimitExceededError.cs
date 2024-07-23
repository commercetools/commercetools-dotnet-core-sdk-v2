namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLResourceSizeLimitExceededError : IGraphQLResourceSizeLimitExceededError
    {
        public string Code { get; set; }
        public GraphQLResourceSizeLimitExceededError()
        {
            this.Code = "ResourceSizeLimitExceeded";
        }
    }
}
