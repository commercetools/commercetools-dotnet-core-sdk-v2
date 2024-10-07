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
    }
}
