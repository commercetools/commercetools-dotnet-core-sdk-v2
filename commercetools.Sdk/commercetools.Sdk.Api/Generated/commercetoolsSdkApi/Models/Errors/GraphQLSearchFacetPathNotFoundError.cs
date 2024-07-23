namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLSearchFacetPathNotFoundError : IGraphQLSearchFacetPathNotFoundError
    {
        public string Code { get; set; }
        public GraphQLSearchFacetPathNotFoundError()
        {
            this.Code = "SearchFacetPathNotFound";
        }
    }
}
