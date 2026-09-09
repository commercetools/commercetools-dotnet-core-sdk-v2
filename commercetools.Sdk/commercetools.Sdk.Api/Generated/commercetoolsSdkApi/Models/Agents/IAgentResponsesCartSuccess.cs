using commercetools.Sdk.Api.Models.Carts;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Agents
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Agents.AgentResponsesCartSuccess))]
    public partial interface IAgentResponsesCartSuccess : IAgentResponsesSuccess
    {
        ICart Entity { get; set; }

    }
}
