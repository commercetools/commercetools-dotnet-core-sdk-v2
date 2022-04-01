using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Types
{
    public partial class TypeReference : ITypeReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IType Obj { get; set; }
        public TypeReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("type");
        }
    }
}
