using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace commercetools.Sdk.Api.Models.Agents
{

    public partial class AgentResponsesMultipartRequest : IAgentResponsesMultipartRequest
    {
        public IAgentResponsesPayload Payload { get; set; }

        public IList<Stream> Files { get; set; }

        public IEnumerable<Stream> FilesEnumerable { set => Files = value.ToList(); }
    }
}
