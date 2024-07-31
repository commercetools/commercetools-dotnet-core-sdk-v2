

namespace commercetools.Sdk.Api.Models.Extensions
{

    public partial class ExtensionChangeDestinationAction : IExtensionChangeDestinationAction
    {
        public string Action { get; set; }

        public IExtensionDestination Destination { get; set; }
        public ExtensionChangeDestinationAction()
        {
            this.Action = "changeDestination";
        }
    }
}
