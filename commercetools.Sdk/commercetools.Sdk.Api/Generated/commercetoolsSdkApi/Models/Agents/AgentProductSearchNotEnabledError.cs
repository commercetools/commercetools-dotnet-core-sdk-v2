namespace commercetools.Sdk.Api.Models.Agents
{

    public partial class AgentProductSearchNotEnabledError : IAgentProductSearchNotEnabledError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public AgentProductSearchNotEnabledError()
        {
            this.Code = "ProductSearchNotEnabled";
        }
    }
}
