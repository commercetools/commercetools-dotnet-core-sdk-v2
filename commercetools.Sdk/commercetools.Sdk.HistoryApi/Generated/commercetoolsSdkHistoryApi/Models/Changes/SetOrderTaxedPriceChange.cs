using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetOrderTaxedPriceChange : ISetOrderTaxedPriceChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ITaxedPrice PreviousValue { get; set; }

        public ITaxedPrice NextValue { get; set; }

        public ITaxMode TaxMode { get; set; }
        public SetOrderTaxedPriceChange()
        {
            this.Type = "SetOrderTaxedPriceChange";
        }
    }
}
