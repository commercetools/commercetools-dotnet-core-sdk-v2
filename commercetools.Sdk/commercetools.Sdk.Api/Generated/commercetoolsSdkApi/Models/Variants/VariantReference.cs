using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Variants
{

    public partial class VariantReference : IVariantReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IVariant Obj { get; set; }
        public VariantReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("variant");
        }
    }
}
