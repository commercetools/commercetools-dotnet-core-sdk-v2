using System.Collections.Generic;
using System.Linq;
using System.IO;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Agents
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Agents.AgentResponsesMultipartRequest))]
    public partial interface IAgentResponsesMultipartRequest
    {
        IAgentResponsesPayload Payload { get; set; }

        IList<Stream> Files { get; set; }

        IEnumerable<Stream> FilesEnumerable { set => Files = value.ToList(); }

    }
}
