using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Extensions
{

    public partial class ExtensionSetExpansionPathsAction : IExtensionSetExpansionPathsAction
    {
        public string Action { get; set; }

        public IList<string> ExpansionPaths { get; set; }

        public IEnumerable<string> ExpansionPathsEnumerable { set => ExpansionPaths = value.ToList(); }
        public ExtensionSetExpansionPathsAction()
        {
            this.Action = "setExpansionPaths";
        }
    }
}
