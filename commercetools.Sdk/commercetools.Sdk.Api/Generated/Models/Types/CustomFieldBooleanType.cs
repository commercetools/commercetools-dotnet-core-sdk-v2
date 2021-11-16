namespace commercetools.Api.Models.Types
{
    public partial class CustomFieldBooleanType : ICustomFieldBooleanType
    {
        public string Name { get; set;}
        public CustomFieldBooleanType()
        { 
           this.Name = "Boolean";
        }
    }
}
