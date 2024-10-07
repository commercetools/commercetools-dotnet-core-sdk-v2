

namespace commercetools.Sdk.ImportApi.Models.Types
{

    public partial class CustomFieldSetType : ICustomFieldSetType
    {
        public string Name { get; set; }

        public IFieldType ElementType { get; set; }
        public CustomFieldSetType()
        {
            this.Name = "Set";
        }
    }
}
