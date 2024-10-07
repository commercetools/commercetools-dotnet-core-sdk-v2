using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Extensions
{

    public partial class ExtensionUpdate : IExtensionUpdate
    {
        public long Version { get; set; }

        public IList<IExtensionUpdateAction> Actions { get; set; }

        public IEnumerable<IExtensionUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }
    }
}
