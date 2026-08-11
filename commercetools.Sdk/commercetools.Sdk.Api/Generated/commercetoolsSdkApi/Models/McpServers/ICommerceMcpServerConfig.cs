using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.McpServers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.McpServers.CommerceMcpServerConfig))]
    public partial interface ICommerceMcpServerConfig : IMcpServerConfig
    {
        string MajorVersion { get; set; }

        string Url { get; set; }

        IList<IMcpServerTool> Tools { get; set; }

        IEnumerable<IMcpServerTool> ToolsEnumerable { set => Tools = value.ToList(); }

        IList<IToolCustomization> ToolCustomizations { get; set; }

        IEnumerable<IToolCustomization> ToolCustomizationsEnumerable { set => ToolCustomizations = value.ToList(); }

        IMcpServerJsonOutputFiltering JsonOutputFiltering { get; set; }

        IMcpServerToolOutputFormatting ToolOutputFormatting { get; set; }

    }
}
