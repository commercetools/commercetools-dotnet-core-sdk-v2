using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Extensions
{

    public partial class ExtensionReference : IExtensionReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IExtension Obj { get; set; }
        public ExtensionReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("extension");
        }
    }
}
