namespace commercetools.Sdk.Api.Models.Agents
{

    public partial class AgentBusinessUnitLimitExceededError : IAgentBusinessUnitLimitExceededError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public AgentBusinessUnitLimitExceededError()
        {
            this.Code = "BusinessUnitLimitExceeded";
        }
    }
}
