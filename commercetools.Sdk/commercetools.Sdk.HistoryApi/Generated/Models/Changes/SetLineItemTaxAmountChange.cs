using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetLineItemTaxAmountChange : ISetLineItemTaxAmountChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ILocalizedString LineItem { get; set; }

        public string Variant { get; set; }

        public ITaxMode TaxMode { get; set; }

        public ITaxRate NextValue { get; set; }

        public ITaxRate PreviousValue { get; set; }
        public SetLineItemTaxAmountChange()
        {
            this.Type = "SetLineItemTaxAmountChange";
        }
    }
}
