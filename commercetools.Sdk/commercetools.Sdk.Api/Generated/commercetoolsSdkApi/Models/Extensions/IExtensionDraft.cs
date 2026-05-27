using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Extensions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Extensions.ExtensionDraft))]
    public partial interface IExtensionDraft
    {
        string Key { get; set; }

        IExtensionDestination Destination { get; set; }

        IList<IExtensionTrigger> Triggers { get; set; }

        IEnumerable<IExtensionTrigger> TriggersEnumerable { set => Triggers = value.ToList(); }

        int? TimeoutInMs { get; set; }

        IList<IExtensionResourceIdentifier> Dependencies { get; set; }

        IEnumerable<IExtensionResourceIdentifier> DependenciesEnumerable { set => Dependencies = value.ToList(); }

        IList<string> ExpansionPaths { get; set; }

        IEnumerable<string> ExpansionPathsEnumerable { set => ExpansionPaths = value.ToList(); }

        IExtensionAdditionalContextDraft AdditionalContext { get; set; }

    }
}
