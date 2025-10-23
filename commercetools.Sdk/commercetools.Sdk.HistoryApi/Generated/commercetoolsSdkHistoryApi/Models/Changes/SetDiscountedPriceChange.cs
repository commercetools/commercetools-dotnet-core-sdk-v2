using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetDiscountedPriceChange : ISetDiscountedPriceChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IDiscountedPrice PreviousValue { get; set; }

        public IDiscountedPrice NextValue { get; set; }

        public string CatalogData { get; set; }

        public string Variant { get; set; }

        public string PriceId { get; set; }

        public IPrice Price { get; set; }
        public SetDiscountedPriceChange()
        {
            this.Type = "SetDiscountedPriceChange";
        }
    }
}
