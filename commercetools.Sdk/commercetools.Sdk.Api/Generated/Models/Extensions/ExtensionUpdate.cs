using System.Collections.Generic;


namespace commercetools.Api.Models.Extensions
{
    public partial class ExtensionUpdate : IExtensionUpdate
    {
        public long Version { get; set; }

        public List<IExtensionUpdateAction> Actions { get; set; }
    }
}
