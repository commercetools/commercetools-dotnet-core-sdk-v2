using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.McpServers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.McpServers.McpServerSetToolCustomizationsAction))]
    public partial interface IMcpServerSetToolCustomizationsAction : IMcpServerUpdateAction
    {
        IList<IToolCustomization> ToolCustomizations { get; set; }

        IEnumerable<IToolCustomization> ToolCustomizationsEnumerable { set => ToolCustomizations = value.ToList(); }

    }
}
