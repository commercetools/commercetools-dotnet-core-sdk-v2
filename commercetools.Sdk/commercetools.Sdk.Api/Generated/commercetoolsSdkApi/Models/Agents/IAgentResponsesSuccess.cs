using commercetools.Sdk.Api.Models.Warnings;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Agents
{
    [TypeDiscriminator(nameof(EntityType))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Agents.AgentResponsesSuccess))]
    [SubTypeDiscriminator("Cart", typeof(commercetools.Sdk.Api.Models.Agents.AgentResponsesCartSuccess))]
    [SubTypeDiscriminator("QuoteRequest", typeof(commercetools.Sdk.Api.Models.Agents.AgentResponsesQuoteRequestSuccess))]
    public partial interface IAgentResponsesSuccess
    {
        IAgentResponsesOutputType EntityType { get; set; }

        IList<IWarningObject> Warnings { get; set; }

        IEnumerable<IWarningObject> WarningsEnumerable { set => Warnings = value.ToList(); }

        string ThreadId { get; set; }

        static commercetools.Sdk.Api.Models.Agents.AgentResponsesCartSuccess Cart(Action<commercetools.Sdk.Api.Models.Agents.AgentResponsesCartSuccess> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Agents.AgentResponsesCartSuccess();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Agents.AgentResponsesQuoteRequestSuccess QuoteRequest(Action<commercetools.Sdk.Api.Models.Agents.AgentResponsesQuoteRequestSuccess> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Agents.AgentResponsesQuoteRequestSuccess();
            init?.Invoke(t);
            return t;
        }
    }
}
