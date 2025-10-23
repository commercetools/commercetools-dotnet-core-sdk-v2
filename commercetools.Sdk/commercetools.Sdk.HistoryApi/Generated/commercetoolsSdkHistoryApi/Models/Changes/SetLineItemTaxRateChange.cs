using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetLineItemTaxRateChange : ISetLineItemTaxRateChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ITaxRate PreviousValue { get; set; }

        public ITaxRate NextValue { get; set; }

        public ILocalizedString LineItem { get; set; }

        public string Variant { get; set; }

        public ITaxMode TaxMode { get; set; }

        public string LineItemId { get; set; }
        public SetLineItemTaxRateChange()
        {
            this.Type = "SetLineItemTaxRateChange";
        }
    }
}
