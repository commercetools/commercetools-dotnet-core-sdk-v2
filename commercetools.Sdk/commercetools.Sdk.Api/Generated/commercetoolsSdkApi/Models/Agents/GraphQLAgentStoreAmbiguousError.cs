namespace commercetools.Sdk.Api.Models.Agents
{

    public partial class GraphQLAgentStoreAmbiguousError : IGraphQLAgentStoreAmbiguousError
    {
        public string Code { get; set; }
        public GraphQLAgentStoreAmbiguousError()
        {
            this.Code = "StoreAmbiguous";
        }
    }
}
