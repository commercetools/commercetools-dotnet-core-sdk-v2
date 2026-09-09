namespace commercetools.Sdk.Api.Models.Agents
{

    public partial class AgentOutOfScopeError : IAgentOutOfScopeError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public AgentOutOfScopeError()
        {
            this.Code = "OutOfScope";
        }
    }
}
