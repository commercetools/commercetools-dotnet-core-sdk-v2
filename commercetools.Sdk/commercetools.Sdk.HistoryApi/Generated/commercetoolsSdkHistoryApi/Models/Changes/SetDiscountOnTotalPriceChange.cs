using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetDiscountOnTotalPriceChange : ISetDiscountOnTotalPriceChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IDiscountOnTotalPrice PreviousValue { get; set; }

        public IDiscountOnTotalPrice NextValue { get; set; }
        public SetDiscountOnTotalPriceChange()
        {
            this.Type = "SetDiscountOnTotalPriceChange";
        }
    }
}
