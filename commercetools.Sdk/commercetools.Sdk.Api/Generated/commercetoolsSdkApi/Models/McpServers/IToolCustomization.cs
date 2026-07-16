using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.McpServers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.McpServers.ToolCustomization))]
    public partial interface IToolCustomization
    {
        IMcpServerTool Tool { get; set; }

        string Description { get; set; }

        IList<IParameterOverride> Parameters { get; set; }

        IEnumerable<IParameterOverride> ParametersEnumerable { set => Parameters = value.ToList(); }

    }
}
