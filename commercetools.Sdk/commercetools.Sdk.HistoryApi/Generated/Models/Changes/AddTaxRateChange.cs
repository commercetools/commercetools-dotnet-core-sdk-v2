using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class AddTaxRateChange : IAddTaxRateChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ITaxRate NextValue { get; set; }
        public AddTaxRateChange()
        {
            this.Type = "AddTaxRateChange";
        }
    }
}
