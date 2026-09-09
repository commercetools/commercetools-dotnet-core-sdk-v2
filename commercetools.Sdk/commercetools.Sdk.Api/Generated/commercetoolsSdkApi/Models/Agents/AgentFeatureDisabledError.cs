namespace commercetools.Sdk.Api.Models.Agents
{

    public partial class AgentFeatureDisabledError : IAgentFeatureDisabledError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public AgentFeatureDisabledError()
        {
            this.Code = "FeatureDisabled";
        }
    }
}
