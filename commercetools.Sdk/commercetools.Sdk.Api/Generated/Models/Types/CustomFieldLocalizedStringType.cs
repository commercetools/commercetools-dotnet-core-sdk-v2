namespace commercetools.Sdk.Api.Models.Types
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
