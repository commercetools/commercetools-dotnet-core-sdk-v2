namespace commercetools.Sdk.Api.Models.Agents
{

    public partial class AgentBusinessUnitAmbiguousError : IAgentBusinessUnitAmbiguousError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public AgentBusinessUnitAmbiguousError()
        {
            this.Code = "BusinessUnitAmbiguous";
        }
    }
}
