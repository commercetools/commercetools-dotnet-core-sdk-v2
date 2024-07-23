using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Types
{

    public partial class TypeResourceIdentifier : ITypeResourceIdentifier
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public string Key { get; set; }
        public TypeResourceIdentifier()
        {
            this.TypeId = IReferenceTypeId.FindEnum("type");
        }
    }
}
