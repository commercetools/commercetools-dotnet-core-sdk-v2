using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Extensions
{
    public partial class ExtensionTrigger : IExtensionTrigger
    {
        public IExtensionResourceTypeId ResourceTypeId { get; set; }

        public List<IExtensionAction> Actions { get; set; }
    }
}
