using commercetools.Sdk.ImportApi.Models.Common;


namespace commercetools.Sdk.ImportApi.Models.Types
{

    public partial class CustomFieldLocalizedEnumValue : ICustomFieldLocalizedEnumValue
    {
        public string Key { get; set; }

        public ILocalizedString Label { get; set; }
    }
}
