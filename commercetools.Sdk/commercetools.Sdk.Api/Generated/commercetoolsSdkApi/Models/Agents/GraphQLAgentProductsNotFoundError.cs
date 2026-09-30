namespace commercetools.Sdk.Api.Models.Agents
{

    public partial class GraphQLAgentProductsNotFoundError : IGraphQLAgentProductsNotFoundError
    {
        public string Code { get; set; }
        public GraphQLAgentProductsNotFoundError()
        {
            this.Code = "ProductsNotFound";
        }
    }
}
