using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetOrderTotalTaxChange : ISetOrderTotalTaxChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ITaxMode TaxMode { get; set; }

        public IMoney NextValue { get; set; }

        public IMoney PreviousValue { get; set; }
        public SetOrderTotalTaxChange()
        {
            this.Type = "SetOrderTotalTaxChange";
        }
    }
}
