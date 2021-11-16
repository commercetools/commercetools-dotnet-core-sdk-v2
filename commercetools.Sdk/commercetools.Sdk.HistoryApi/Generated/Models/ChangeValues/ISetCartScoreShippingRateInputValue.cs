using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.ChangeValues.SetCartScoreShippingRateInputValue))]
    public partial interface ISetCartScoreShippingRateInputValue 
    {
        string Type { get; set;}
        
        int Score { get; set;}
    }
}
