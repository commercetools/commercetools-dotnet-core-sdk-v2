using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{
    public partial class SetCartClassificationShippingRateInputValue : ISetCartClassificationShippingRateInputValue
    {
        public string Type { get; set; }

        public string Key { get; set; }

        public ILocalizedString Label { get; set; }
    }
}
