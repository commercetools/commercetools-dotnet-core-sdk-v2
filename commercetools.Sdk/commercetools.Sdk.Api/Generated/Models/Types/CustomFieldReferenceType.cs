using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Types
{
    public partial class CustomFieldReferenceType : ICustomFieldReferenceType
    {
        public string Name { get; set; }

        public IReferenceTypeId ReferenceTypeId { get; set; }
        public CustomFieldReferenceType()
        {
            this.Name = "Reference";
        }
    }
}
