using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.McpServers
{

    public partial class ToolCustomization : IToolCustomization
    {
        public IMcpServerTool Tool { get; set; }

        public string Description { get; set; }

        public IList<IParameterOverride> Parameters { get; set; }

        public IEnumerable<IParameterOverride> ParametersEnumerable { set => Parameters = value.ToList(); }
    }
}
