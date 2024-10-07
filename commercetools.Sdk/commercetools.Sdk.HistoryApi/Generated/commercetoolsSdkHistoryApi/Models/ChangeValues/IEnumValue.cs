using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.ChangeValues.EnumValue))]
    public partial interface IEnumValue
    {
        string Key { get; set; }

        string Label { get; set; }

    }
}
