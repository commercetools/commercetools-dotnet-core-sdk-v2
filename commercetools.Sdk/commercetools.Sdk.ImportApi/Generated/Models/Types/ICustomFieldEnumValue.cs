using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Types
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Types.CustomFieldEnumValue))]
    public partial interface ICustomFieldEnumValue
    {
        string Key { get; set; }

        string Label { get; set; }

    }
}
