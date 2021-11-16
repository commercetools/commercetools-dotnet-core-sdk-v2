namespace commercetools.Api.Models.Types
{
    public partial class CustomFieldTimeType : ICustomFieldTimeType
    {
        public string Name { get; set;}
        public CustomFieldTimeType()
        { 
           this.Name = "Time";
        }
    }
}
