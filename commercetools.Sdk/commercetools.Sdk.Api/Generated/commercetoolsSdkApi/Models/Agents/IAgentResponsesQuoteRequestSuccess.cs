using commercetools.Sdk.Api.Models.QuoteRequests;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Agents
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Agents.AgentResponsesQuoteRequestSuccess))]
    public partial interface IAgentResponsesQuoteRequestSuccess : IAgentResponsesSuccess
    {
        IQuoteRequest Entity { get; set; }

        string CartId { get; set; }

    }
}
