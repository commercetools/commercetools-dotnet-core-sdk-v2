namespace commercetools.Sdk.Api.Models.Agents
{

    public partial class AgentMissingCountryError : IAgentMissingCountryError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public AgentMissingCountryError()
        {
            this.Code = "MissingCountry";
        }
    }
}
