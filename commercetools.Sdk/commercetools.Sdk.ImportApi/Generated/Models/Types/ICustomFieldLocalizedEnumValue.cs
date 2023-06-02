using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Types
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Types.CustomFieldLocalizedEnumValue))]
    public partial interface ICustomFieldLocalizedEnumValue
    {
        string Key { get; set; }

        ILocalizedString Label { get; set; }

    }
}
