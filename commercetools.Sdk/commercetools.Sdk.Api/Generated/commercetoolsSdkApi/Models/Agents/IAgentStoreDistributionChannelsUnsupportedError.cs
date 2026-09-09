using commercetools.Sdk.Api.Models.Errors;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Agents
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Agents.AgentStoreDistributionChannelsUnsupportedError))]
    public partial interface IAgentStoreDistributionChannelsUnsupportedError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

    }
}
