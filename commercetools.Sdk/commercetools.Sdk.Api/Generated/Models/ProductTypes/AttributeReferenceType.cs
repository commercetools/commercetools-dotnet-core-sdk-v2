using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.ProductTypes
{
    public partial class AttributeReferenceType : IAttributeReferenceType
    {
        public string Name { get; set; }

        public IReferenceTypeId ReferenceTypeId { get; set; }
        public AttributeReferenceType()
        {
            this.Name = "reference";
        }
    }
}
