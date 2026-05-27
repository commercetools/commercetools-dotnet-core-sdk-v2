using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Extensions
{

    public partial class ExtensionResourceIdentifier : IExtensionResourceIdentifier
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public string Key { get; set; }
        public ExtensionResourceIdentifier()
        {
            this.TypeId = IReferenceTypeId.FindEnum("extension");
        }
    }
}
