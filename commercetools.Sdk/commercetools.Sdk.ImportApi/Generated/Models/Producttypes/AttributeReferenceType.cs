using commercetools.ImportApi.Models.Common;


namespace commercetools.ImportApi.Models.Producttypes
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
