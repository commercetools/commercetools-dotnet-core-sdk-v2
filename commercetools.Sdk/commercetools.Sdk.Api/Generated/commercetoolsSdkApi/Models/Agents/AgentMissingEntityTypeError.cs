namespace commercetools.Sdk.Api.Models.Agents
{

    public partial class AgentMissingEntityTypeError : IAgentMissingEntityTypeError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public AgentMissingEntityTypeError()
        {
            this.Code = "MissingEntityType";
        }
    }
}
