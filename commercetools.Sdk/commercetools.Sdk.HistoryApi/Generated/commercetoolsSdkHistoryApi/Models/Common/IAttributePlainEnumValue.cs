using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.AttributePlainEnumValue))]
    public partial interface IAttributePlainEnumValue
    {
        string Key { get; set; }

        string Label { get; set; }

    }
}
