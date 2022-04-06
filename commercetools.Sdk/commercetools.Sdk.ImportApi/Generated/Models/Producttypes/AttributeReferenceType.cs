using commercetools.Sdk.ImportApi.Models.Common;


namespace commercetools.Sdk.ImportApi.Models.Producttypes
{
    public partial class AttributeReferenceType : IAttributeReferenceType
    {
        public string Name { get; set; }

        public IReferenceType ReferenceTypeId { get; set; }
        public AttributeReferenceType()
        {
            this.Name = "reference";
        }
    }
}
