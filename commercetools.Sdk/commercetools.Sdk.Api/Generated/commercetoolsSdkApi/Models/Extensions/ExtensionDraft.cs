using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Extensions
{

    public partial class ExtensionDraft : IExtensionDraft
    {
        public string Key { get; set; }

        public IExtensionDestination Destination { get; set; }

        public IList<IExtensionTrigger> Triggers { get; set; }

        public IEnumerable<IExtensionTrigger> TriggersEnumerable { set => Triggers = value.ToList(); }

        public int? TimeoutInMs { get; set; }

        public IList<IExtensionResourceIdentifier> Dependencies { get; set; }

        public IEnumerable<IExtensionResourceIdentifier> DependenciesEnumerable { set => Dependencies = value.ToList(); }

        public IList<string> ExpansionPaths { get; set; }

        public IEnumerable<string> ExpansionPathsEnumerable { set => ExpansionPaths = value.ToList(); }

        public IExtensionAdditionalContextDraft AdditionalContext { get; set; }
    }
}
