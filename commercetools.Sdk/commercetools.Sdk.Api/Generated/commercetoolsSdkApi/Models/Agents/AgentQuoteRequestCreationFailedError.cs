namespace commercetools.Sdk.Api.Models.Agents
{

    public partial class AgentQuoteRequestCreationFailedError : IAgentQuoteRequestCreationFailedError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public string CartId { get; set; }
        public AgentQuoteRequestCreationFailedError()
        {
            this.Code = "QuoteRequestCreationFailed";
        }
    }
}
