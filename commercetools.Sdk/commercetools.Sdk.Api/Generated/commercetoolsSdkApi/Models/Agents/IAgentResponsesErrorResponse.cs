using commercetools.Sdk.Api.Models.Errors;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Agents
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Agents.AgentResponsesErrorResponse))]
    public partial interface IAgentResponsesErrorResponse : IErrorResponse
    {
        new IList<IErrorObject> Errors { get; set; }

        new IEnumerable<IErrorObject> ErrorsEnumerable { set => Errors = value.ToList(); }

        string ThreadId { get; set; }

    }
}
