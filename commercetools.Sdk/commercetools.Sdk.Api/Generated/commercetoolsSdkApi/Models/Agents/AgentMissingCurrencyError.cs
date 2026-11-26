namespace commercetools.Sdk.Api.Models.Agents
{

    public partial class AgentMissingCurrencyError : IAgentMissingCurrencyError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public AgentMissingCurrencyError()
        {
            this.Code = "MissingCurrency";
        }
    }
}
