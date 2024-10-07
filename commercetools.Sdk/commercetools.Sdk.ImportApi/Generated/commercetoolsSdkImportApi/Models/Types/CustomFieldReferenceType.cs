

namespace commercetools.Sdk.ImportApi.Models.Types
{

    public partial class CustomFieldReferenceType : ICustomFieldReferenceType
    {
        public string Name { get; set; }

        public ICustomFieldReferenceValue ReferenceTypeId { get; set; }
        public CustomFieldReferenceType()
        {
            this.Name = "Reference";
        }
    }
}
