using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Agents
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Agents.AgentResponsesRequest))]
    public partial interface IAgentResponsesRequest
    {
        IAgentResponsesOutputType OutputType { get; set; }

        string Locale { get; set; }

        string Prompt { get; set; }

        IBusinessUnitResourceIdentifier BusinessUnit { get; set; }

        IStoreResourceIdentifier Store { get; set; }

    }
}
