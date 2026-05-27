using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Extensions
{

    public partial class ExtensionSetDependenciesAction : IExtensionSetDependenciesAction
    {
        public string Action { get; set; }

        public IList<IExtensionResourceIdentifier> Dependencies { get; set; }

        public IEnumerable<IExtensionResourceIdentifier> DependenciesEnumerable { set => Dependencies = value.ToList(); }
        public ExtensionSetDependenciesAction()
        {
            this.Action = "setDependencies";
        }
    }
}
