namespace commercetools.Sdk.Api.Models.Agents
{

    public partial class AgentStoreUnresolvedError : IAgentStoreUnresolvedError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public AgentStoreUnresolvedError()
        {
            this.Code = "StoreUnresolved";
        }
    }
}
