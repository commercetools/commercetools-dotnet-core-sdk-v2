namespace commercetools.Sdk.Api.Models.Agents
{

    public partial class AgentExtractionFailedError : IAgentExtractionFailedError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public AgentExtractionFailedError()
        {
            this.Code = "ExtractionFailed";
        }
    }
}
