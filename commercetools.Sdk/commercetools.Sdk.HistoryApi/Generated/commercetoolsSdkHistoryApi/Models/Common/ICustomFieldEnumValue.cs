using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.CustomFieldEnumValue))]
    public partial interface ICustomFieldEnumValue
    {
        string Key { get; set; }

        string Label { get; set; }

    }
}
