namespace commercetools.Api.Models.Types
{
    public partial class CustomFieldNumberType : ICustomFieldNumberType
    {
        public string Name { get; set;}
        public CustomFieldNumberType()
        { 
           this.Name = "Number";
        }
    }
}
