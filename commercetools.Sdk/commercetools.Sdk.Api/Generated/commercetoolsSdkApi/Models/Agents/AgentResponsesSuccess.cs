using commercetools.Sdk.Api.Models.Warnings;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Agents
{

    public partial class AgentResponsesSuccess : IAgentResponsesSuccess
    {
        public IAgentResponsesOutputType EntityType { get; set; }

        public IList<IWarningObject> Warnings { get; set; }

        public IEnumerable<IWarningObject> WarningsEnumerable { set => Warnings = value.ToList(); }

        public string ThreadId { get; set; }
    }
}
