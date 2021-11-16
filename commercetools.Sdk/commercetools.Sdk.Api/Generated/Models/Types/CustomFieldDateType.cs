namespace commercetools.Api.Models.Types
{
    public partial class CustomFieldDateType : ICustomFieldDateType
    {
        public string Name { get; set; }
        public CustomFieldDateType()
        {
            this.Name = "Date";
        }
    }
}
