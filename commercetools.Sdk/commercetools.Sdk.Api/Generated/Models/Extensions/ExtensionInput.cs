using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Extensions
{
    public partial class ExtensionInput : IExtensionInput
    {
        public IExtensionAction Action { get; set; }

        public IReference Resource { get; set; }
    }
}
