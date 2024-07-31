

namespace commercetools.Sdk.Api.Models.ProductTypes
{

    public partial class AttributeReferenceType : IAttributeReferenceType
    {
        public string Name { get; set; }

        public IAttributeReferenceTypeId ReferenceTypeId { get; set; }
        public AttributeReferenceType()
        {
            this.Name = "reference";
        }
    }
}
