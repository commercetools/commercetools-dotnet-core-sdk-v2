using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class RemoveTaxRateChange : IRemoveTaxRateChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ITaxRate PreviousValue { get; set; }

        public ITaxRate NextValue { get; set; }
        public RemoveTaxRateChange()
        {
            this.Type = "RemoveTaxRateChange";
        }
    }
}
