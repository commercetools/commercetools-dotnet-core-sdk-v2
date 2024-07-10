namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLResourceNotFoundError : IGraphQLResourceNotFoundError
    {
        public string Code { get; set; }
        public GraphQLResourceNotFoundError()
        {
            this.Code = "ResourceNotFound";
        }
    }
}
