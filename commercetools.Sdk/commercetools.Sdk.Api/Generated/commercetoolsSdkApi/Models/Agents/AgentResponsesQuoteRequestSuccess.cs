using commercetools.Sdk.Api.Models.QuoteRequests;
using commercetools.Sdk.Api.Models.Warnings;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Agents
{

    public partial class AgentResponsesQuoteRequestSuccess : IAgentResponsesQuoteRequestSuccess
    {
        public IAgentResponsesOutputType EntityType { get; set; }

        public IList<IWarningObject> Warnings { get; set; }

        public IEnumerable<IWarningObject> WarningsEnumerable { set => Warnings = value.ToList(); }

        public string ThreadId { get; set; }

        public IQuoteRequest Entity { get; set; }

        public string CartId { get; set; }
        public AgentResponsesQuoteRequestSuccess()
        {
            this.EntityType = IAgentResponsesOutputType.FindEnum("QuoteRequest");
        }
    }
}
