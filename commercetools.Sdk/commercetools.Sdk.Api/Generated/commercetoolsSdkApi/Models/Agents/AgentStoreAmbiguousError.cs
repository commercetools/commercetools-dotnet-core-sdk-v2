namespace commercetools.Sdk.Api.Models.Agents
{

    public partial class AgentStoreAmbiguousError : IAgentStoreAmbiguousError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public AgentStoreAmbiguousError()
        {
            this.Code = "StoreAmbiguous";
        }
    }
}
