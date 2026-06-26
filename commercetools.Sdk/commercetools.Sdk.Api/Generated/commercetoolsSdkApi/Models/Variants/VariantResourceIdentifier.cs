using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Variants
{

    public partial class VariantResourceIdentifier : IVariantResourceIdentifier
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public string Key { get; set; }
        public VariantResourceIdentifier()
        {
            this.TypeId = IReferenceTypeId.FindEnum("variant");
        }
    }
}
