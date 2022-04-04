using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Types
{
    public partial class CustomFieldLocalizedEnumValue : ICustomFieldLocalizedEnumValue
    {
        public string Key { get; set; }

        public ILocalizedString Label { get; set; }
    }
}
