namespace commercetools.Api.Models.Types
{
    public partial class CustomFieldStringType : ICustomFieldStringType
    {
        public string Name { get; set; }
        public CustomFieldStringType()
        {
            this.Name = "String";
        }
    }
}
