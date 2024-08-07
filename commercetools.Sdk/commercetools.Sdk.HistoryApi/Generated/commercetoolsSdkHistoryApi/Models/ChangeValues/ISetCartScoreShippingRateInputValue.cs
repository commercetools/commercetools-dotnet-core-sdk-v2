using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.ChangeValues.SetCartScoreShippingRateInputValue))]
    public partial interface ISetCartScoreShippingRateInputValue
    {
        string Type { get; set; }

        int Score { get; set; }

    }
}
