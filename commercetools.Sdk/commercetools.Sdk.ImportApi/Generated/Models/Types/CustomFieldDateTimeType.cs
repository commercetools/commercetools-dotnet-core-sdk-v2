namespace commercetools.Sdk.ImportApi.Models.Types
{

    public partial class CustomFieldDateTimeType : ICustomFieldDateTimeType
    {
        public string Name { get; set; }
        public CustomFieldDateTimeType()
        {
            this.Name = "DateTime";
        }
    }
}
