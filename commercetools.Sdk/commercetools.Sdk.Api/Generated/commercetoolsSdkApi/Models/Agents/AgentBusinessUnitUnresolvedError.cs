namespace commercetools.Sdk.Api.Models.Agents
{

    public partial class AgentBusinessUnitUnresolvedError : IAgentBusinessUnitUnresolvedError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public AgentBusinessUnitUnresolvedError()
        {
            this.Code = "BusinessUnitUnresolved";
        }
    }
}
