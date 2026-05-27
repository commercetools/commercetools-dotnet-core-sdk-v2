using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Extensions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Extensions.ExtensionSetExpansionPathsAction))]
    public partial interface IExtensionSetExpansionPathsAction : IExtensionUpdateAction
    {
        IList<string> ExpansionPaths { get; set; }

        IEnumerable<string> ExpansionPathsEnumerable { set => ExpansionPaths = value.ToList(); }

    }
}
