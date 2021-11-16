using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Types
{
    public partial class CustomFieldLocalizedEnumValue : ICustomFieldLocalizedEnumValue
    {
        public string Key { get; set; }

        public ILocalizedString Label { get; set; }
    }
}
