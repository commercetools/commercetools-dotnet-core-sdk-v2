using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Stores;


namespace commercetools.Sdk.Api.Models.Agents
{

    public partial class AgentResponsesRequest : IAgentResponsesRequest
    {
        public IAgentResponsesOutputType OutputType { get; set; }

        public string Locale { get; set; }

        public string Prompt { get; set; }

        public IBusinessUnitResourceIdentifier BusinessUnit { get; set; }

        public IStoreResourceIdentifier Store { get; set; }
    }
}
