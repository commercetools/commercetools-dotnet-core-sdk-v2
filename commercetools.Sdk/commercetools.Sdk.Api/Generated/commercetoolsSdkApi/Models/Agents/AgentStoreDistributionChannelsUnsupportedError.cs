namespace commercetools.Sdk.Api.Models.Agents
{

    public partial class AgentStoreDistributionChannelsUnsupportedError : IAgentStoreDistributionChannelsUnsupportedError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public AgentStoreDistributionChannelsUnsupportedError()
        {
            this.Code = "StoreDistributionChannelsUnsupported";
        }
    }
}
