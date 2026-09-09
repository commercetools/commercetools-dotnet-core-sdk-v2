namespace commercetools.Sdk.Api.Models.Agents
{

    public partial class AgentMissingCustomerEmailError : IAgentMissingCustomerEmailError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public AgentMissingCustomerEmailError()
        {
            this.Code = "MissingCustomerEmail";
        }
    }
}
