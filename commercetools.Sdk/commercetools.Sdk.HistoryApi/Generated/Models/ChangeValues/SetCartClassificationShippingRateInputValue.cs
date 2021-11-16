using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.ChangeValues
{
    public partial class SetCartClassificationShippingRateInputValue : ISetCartClassificationShippingRateInputValue
    {
        public string Type { get; set;}
        
        public string Key { get; set;}
        
        public ILocalizedString Label { get; set;}
    }
}
