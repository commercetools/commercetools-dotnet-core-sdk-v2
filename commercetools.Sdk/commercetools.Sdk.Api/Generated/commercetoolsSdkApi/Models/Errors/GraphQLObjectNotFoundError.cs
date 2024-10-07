namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLObjectNotFoundError : IGraphQLObjectNotFoundError
    {
        public string Code { get; set; }
        public GraphQLObjectNotFoundError()
        {
            this.Code = "ObjectNotFound";
        }
    }
}
