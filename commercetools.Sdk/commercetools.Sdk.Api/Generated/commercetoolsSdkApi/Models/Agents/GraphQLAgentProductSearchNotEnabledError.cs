namespace commercetools.Sdk.Api.Models.Agents
{

    public partial class GraphQLAgentProductSearchNotEnabledError : IGraphQLAgentProductSearchNotEnabledError
    {
        public string Code { get; set; }
        public GraphQLAgentProductSearchNotEnabledError()
        {
            this.Code = "ProductSearchNotEnabled";
        }
    }
}
