using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.McpServers
{

    public partial class McpServerSetToolCustomizationsAction : IMcpServerSetToolCustomizationsAction
    {
        public string Action { get; set; }

        public IList<IToolCustomization> ToolCustomizations { get; set; }

        public IEnumerable<IToolCustomization> ToolCustomizationsEnumerable { set => ToolCustomizations = value.ToList(); }
        public McpServerSetToolCustomizationsAction()
        {
            this.Action = "setToolCustomizations";
        }
    }
}
