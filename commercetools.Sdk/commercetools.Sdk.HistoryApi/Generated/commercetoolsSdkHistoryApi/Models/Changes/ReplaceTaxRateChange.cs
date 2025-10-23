using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ReplaceTaxRateChange : IReplaceTaxRateChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ITaxRate PreviousValue { get; set; }

        public ITaxRate NextValue { get; set; }
        public ReplaceTaxRateChange()
        {
            this.Type = "ReplaceTaxRateChange";
        }
    }
}
