using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Extensions
{
    public partial class ExtensionInput : IExtensionInput
    {
        public IExtensionAction Action { get; set;}
        
        public IReference Resource { get; set;}
    }
}
