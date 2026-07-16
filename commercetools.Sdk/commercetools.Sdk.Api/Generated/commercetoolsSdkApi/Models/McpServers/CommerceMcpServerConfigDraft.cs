using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.McpServers
{

    public partial class CommerceMcpServerConfigDraft : ICommerceMcpServerConfigDraft
    {
        public string Type { get; set; }

        public string MajorVersion { get; set; }

        public IList<IMcpServerTool> Tools { get; set; }

        public IEnumerable<IMcpServerTool> ToolsEnumerable { set => Tools = value.ToList(); }

        public IList<IToolCustomization> ToolCustomizations { get; set; }

        public IEnumerable<IToolCustomization> ToolCustomizationsEnumerable { set => ToolCustomizations = value.ToList(); }

        public IMcpServerJsonOutputFiltering JsonOutputFiltering { get; set; }

        public IMcpServerToolOutputFormatting ToolOutputFormatting { get; set; }
        public CommerceMcpServerConfigDraft()
        {
            this.Type = "CommerceMCP";
        }
    }
}
