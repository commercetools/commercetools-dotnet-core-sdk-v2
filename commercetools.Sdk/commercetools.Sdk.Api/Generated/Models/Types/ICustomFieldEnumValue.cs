using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Types.CustomFieldEnumValue))]
    public partial interface ICustomFieldEnumValue
    {
        string Key { get; set; }

        string Label { get; set; }

    }
}
