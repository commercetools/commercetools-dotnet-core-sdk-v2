namespace commercetools.Sdk.Api.Models.Agents
{

    public partial class GraphQLAgentStoreUnresolvedError : IGraphQLAgentStoreUnresolvedError
    {
        public string Code { get; set; }
        public GraphQLAgentStoreUnresolvedError()
        {
            this.Code = "StoreUnresolved";
        }
    }
}
