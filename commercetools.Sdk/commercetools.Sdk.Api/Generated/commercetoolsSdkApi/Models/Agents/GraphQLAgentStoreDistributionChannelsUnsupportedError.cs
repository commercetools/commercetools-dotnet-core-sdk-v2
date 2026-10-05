namespace commercetools.Sdk.Api.Models.Agents
{

    public partial class GraphQLAgentStoreDistributionChannelsUnsupportedError : IGraphQLAgentStoreDistributionChannelsUnsupportedError
    {
        public string Code { get; set; }
        public GraphQLAgentStoreDistributionChannelsUnsupportedError()
        {
            this.Code = "StoreDistributionChannelsUnsupported";
        }
    }
}
