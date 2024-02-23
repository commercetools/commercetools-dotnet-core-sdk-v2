namespace commercetools.Sdk.ImportApi.Models.Types
{

    public partial class CustomFieldLocalizedStringType : ICustomFieldLocalizedStringType
    {
        public string Name { get; set; }
        public CustomFieldLocalizedStringType()
        {
            this.Name = "LocalizedString";
        }
    }
}
