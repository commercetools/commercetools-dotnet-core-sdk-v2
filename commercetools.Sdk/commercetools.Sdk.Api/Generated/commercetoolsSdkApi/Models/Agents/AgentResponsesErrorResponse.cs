using commercetools.Sdk.Api.Models.Errors;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Agents
{

    public partial class AgentResponsesErrorResponse : IAgentResponsesErrorResponse
    {
        public int StatusCode { get; set; }

        public string Message { get; set; }

        public IList<IErrorObject> Errors { get; set; }

        public IEnumerable<IErrorObject> ErrorsEnumerable { set => Errors = value.ToList(); }

        public string ThreadId { get; set; }
    }
}
