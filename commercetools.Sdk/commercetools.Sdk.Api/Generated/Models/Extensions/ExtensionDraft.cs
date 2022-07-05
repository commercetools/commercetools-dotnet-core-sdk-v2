using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Extensions
{

    public partial class ExtensionDraft : IExtensionDraft
    {
        public string Key { get; set; }

        public IExtensionDestination Destination { get; set; }

        public List<IExtensionTrigger> Triggers { get; set; }

        public int? TimeoutInMs { get; set; }
    }
}
