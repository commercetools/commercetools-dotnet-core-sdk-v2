namespace commercetools.Sdk.Api.Models.Agents
{

    public partial class AgentNoLineItemsExtractedError : IAgentNoLineItemsExtractedError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public AgentNoLineItemsExtractedError()
        {
            this.Code = "NoLineItemsExtracted";
        }
    }
}
