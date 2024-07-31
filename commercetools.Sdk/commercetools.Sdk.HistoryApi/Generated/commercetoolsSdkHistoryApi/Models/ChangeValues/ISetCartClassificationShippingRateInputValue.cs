using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.ChangeValues.SetCartClassificationShippingRateInputValue))]
    public partial interface ISetCartClassificationShippingRateInputValue
    {
        string Type { get; set; }

        string Key { get; set; }

        ILocalizedString Label { get; set; }

    }
}
