using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.ChangeValues.SetCartScoreShippingRateInputValue))]
    public partial interface ISetCartScoreShippingRateInputValue
    {
        string Type { get; set; }

        int Score { get; set; }

    }
}
